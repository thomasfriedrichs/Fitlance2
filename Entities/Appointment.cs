using System.ComponentModel.DataAnnotations.Schema;

namespace Fitlance.Entities;

[Table("Appointments")]
public class Appointment
{
    public int Id { get; set; }

    public string ClientId { get; set; }

    public string TrainerId { get; set; }

    public DateTime CreateTimeUtc { get; set; }

    public DateTime UpdateTimeUtc { get; set; }

    public DateTime StartTimeUtc { get; set; }

    public DateTime EndTimeUtc { get; set; }

    public string? StreetAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public bool IsActive { get; set; }
}