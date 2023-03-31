using System.ComponentModel.DataAnnotations;

namespace Fitlance.Dtos;

public class LoginRequest
{
    [EmailAddress]
    public string? Email { get; set; }

    public string? Password { get; set; }
}