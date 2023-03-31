using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitlance.Entities;

[Table("Users")]
public class User : IdentityUser
{
    public DateTime? CreateTime { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? City { get; set; }

    public int? ZipCode { get; set; }

    public string? Bio { get; set; }

    public List<Appointment>? Appointments { get; set; }
}