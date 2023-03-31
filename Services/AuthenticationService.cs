using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using Fitlance.Dtos;
using Fitlance.Entities;
using Fitlance.Constants;

namespace Fitlance.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public AuthenticationService(UserManager<User> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }

    public async Task<string> Register(RegisterRequest request)
    {
        await CheckIfUserExists(request, _userManager);

        User user = new()
        {
            Email = request.Email,
            UserName = request.Username,
            SecurityStamp = Guid.NewGuid().ToString()
        };

        var result = await _userManager.CreateAsync(user, request.Password);

        await AddToRole(request.Role, user, _userManager);

        if (!result.Succeeded)
        {
            throw new ArgumentException($"Unable to register user {request.Username} errors: {GetErrorsText(result.Errors)}");
        }

        return await Login(new LoginRequest { Email = request.Email, Password = request.Password });

    }

    public async Task<string> Login(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user is null)
        {
            throw new ArgumentException($"User with email: {request.Email} Not Found");
        }

        if (!await _userManager.CheckPasswordAsync(user, request.Password))
        {
            throw new ArgumentException($"Unable to authenticate user {request.Email}");
        }

        var authClaims = new List<Claim>
        {
            new (ClaimTypes.Name, user.NormalizedUserName),
            new(ClaimTypes.Email, user.Email),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var userRoles = await _userManager.GetRolesAsync(user);

        if (userRoles is not null && userRoles.Any())
        {
            authClaims.AddRange(userRoles.Select(userRole => new Claim(ClaimTypes.Role, userRole)));
        }

        authClaims.Add(new Claim(ClaimTypes.Sid, user.Id));

        authClaims.Add(new Claim("cStamp", user.ConcurrencyStamp));

        var token = GetToken(authClaims);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private static async Task<IdentityResult> CheckIfUserExists(RegisterRequest request, UserManager<User> userManager)
    {
        var userByUsername = await userManager.FindByNameAsync(request.Username);
        var userByEmail = await userManager.FindByEmailAsync(request.Email);

        if (userByEmail is not null)
        {
            throw new ArgumentException($"User with {request.Email} already exists.");
        }
        else if (userByUsername is not null)
        {
            throw new ArgumentException($"User with {request.Username} already exists.");
        }
        else
        {
            return IdentityResult.Success;
        }
    }

    private static async Task<IdentityResult> AddToRole(string role, User user, UserManager<User> userManager)
    {
        if (role == "User")
        {
            var result = await userManager.AddToRoleAsync(user, RoleConstants.User);

            return result;
        }
        else if (role == "Trainer")
        {
            var result = await userManager.AddToRoleAsync(user, RoleConstants.Trainer);

            return result;
        }
        else
        {
            throw new ArgumentException($"Unable to register user, role required");
        }
    }

    private JwtSecurityToken GetToken(IEnumerable<Claim> authClaims)
    {
        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

        var token = new JwtSecurityToken(
            issuer: _configuration["JWT:ValidIssuer"],
            audience: _configuration["JWT:ValidAudience"],
            expires: DateTime.Now.AddHours(3),
            claims: authClaims,
            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

        return token;
    }

    private static string GetErrorsText(IEnumerable<IdentityError> errors)
    {
        return string.Join(", ", errors.Select(error => error.Description).ToArray());
    }
}
