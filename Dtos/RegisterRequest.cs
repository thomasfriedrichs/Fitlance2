using System.ComponentModel.DataAnnotations;

namespace Fitlance.Dtos;

public class RegisterRequest
{
    public string? Username { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }
}