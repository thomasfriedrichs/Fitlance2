using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Fitlance.Entities;
using Fitlance.Dtos;

namespace Fitlance.Data;

public class FitlanceContext : IdentityDbContext<User>
{
    public FitlanceContext(DbContextOptions<FitlanceContext> options)
        : base(options)
    {
    }

    public DbSet<Appointment>? Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.Development.Local.json", true, true)
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("Fitlance");
        modelBuilder.Entity<User>(mb =>
        {
            mb.HasMany<Appointment>().WithOne().HasForeignKey(a => a.ClientId).IsRequired();
            mb.ToTable("AspNetUsers");
        });

        modelBuilder.Entity<Appointment>(a =>
        {
            a.Property(p => p.Id).ValueGeneratedOnAdd();
            a.ToTable("Appointments");
        });

        SeedAppointments(modelBuilder);
    }

    private static void SeedAppointments(ModelBuilder modelBuilder)
    {
        var addresses = new[]
        {
            new {StreetAddress = "2101 N Northlake Way", City = "Seattle", State = "WA", PostalCode = "98103", Country = "USA", Latitude = 47.646711, Longitude = -122.334383 }, // Gas Works Park
            new {StreetAddress = "7201 E Green Lake Dr N", City = "Seattle", State = "WA", PostalCode = "98115", Country = "USA", Latitude = 47.682094, Longitude = -122.327053 }, // Green Lake Park
            new {StreetAddress = "3801 Discovery Park Blvd", City = "Seattle", State = "WA", PostalCode = "98199", Country = "USA", Latitude = 47.658024, Longitude = -122.405937 }, // Discovery Park
            new {StreetAddress = "5900 Lake Washington Blvd S", City = "Seattle", State = "WA", PostalCode = "98118", Country = "USA", Latitude = 47.554881, Longitude = -122.249359 }, // Seward Park
            new {StreetAddress = "1702 Alki Ave SW", City = "Seattle", State = "WA", PostalCode = "98116", Country = "USA", Latitude = 47.581333, Longitude = -122.375772 }, // Alki Beach Park
            new {StreetAddress = "250 W Highland Dr", City = "Seattle", State = "WA", PostalCode = "98119", Country = "USA", Latitude = 47.629368, Longitude = -122.359950 }, // Kerry Park
            new {StreetAddress = "7400 Sand Point Way NE", City = "Seattle", State = "WA", PostalCode = "98115", Country = "USA", Latitude = 47.6825024, Longitude = -122.2639551 }, // Magnuson Park
            new {StreetAddress = "8498 Seaview Pl NW", City = "Seattle", State = "WA", PostalCode = "98117", Country = "USA", Latitude = 47.688877, Longitude = -122.402900 }, // Golden Gardens Park
            new {StreetAddress = "2300 Arboretum Dr E", City = "Seattle", State = "WA", PostalCode = "98112", Country = "USA", Latitude = 47.639869, Longitude = -122.294952 }, // Washington Park Arboretum
            new {StreetAddress = "8011 Fauntleroy Way SW", City = "Seattle", State = "WA", PostalCode = "98136", Country = "USA", Latitude = 47.531378, Longitude = -122.392665 }, // Lincoln Park
            new {StreetAddress = "1247 15th Ave E", City = "Seattle", State = "WA", PostalCode = "98112", Country = "USA", Latitude = 47.632389, Longitude = -122.313691 }, // Volunteer Park
            new {StreetAddress = "100 Dexter Ave N", City = "Seattle", State = "WA", PostalCode = "98109", Country = "USA", Latitude = 47.6291869, Longitude = -122.3424823 }, //Denny Park
            new {StreetAddress = "3318 NE 125th St", City = "Seattle", State = "WA", PostalCode = "98125", Country = "USA", Latitude = 47.717564, Longitude = -122.287299 }, // Magnuson Athletic Club
            new {StreetAddress = "1370 N 10th St", City = "Seattle", State = "WA", PostalCode = "98103", Country = "USA", Latitude = 47.661303, Longitude = -122.331084 }, // Wallingford Fitness
            new {StreetAddress = "918 S Horton St", City = "Seattle", State = "WA", PostalCode = "98134", Country = "USA", Latitude = 47.583003, Longitude = -122.328509 }, // Orangetheory Fitness Seattle - SODO
            new {StreetAddress = "10740 Meridian Ave N Suite 107", City = "Seattle", State = "WA", PostalCode = "98133", Country = "USA", Latitude = 47.706908, Longitude = -122.334736 }, // Northgate F45 Training
            new {StreetAddress = "4036 Stone Way N", City = "Seattle", State = "WA", PostalCode = "98103", Country = "USA", Latitude = 47.654748, Longitude = -122.342235 }, // Fremont Health Club
            new {StreetAddress = "1002 Pontius Ave N", City = "Seattle", State = "WA", PostalCode = "98109", Country = "USA", Latitude = 47.621536, Longitude = -122.338284 }, // Urban Fit Studios
            new {StreetAddress = "6109 13th Ave S", City = "Seattle", State = "WA", PostalCode = "98108", Country = "USA", Latitude = 47.545201, Longitude = -122.313343 }, // Georgetown Fitness
            new {StreetAddress = "4219 W Marginal Way SW", City = "Seattle", State = "WA", PostalCode = "98106", Country = "USA", Latitude = 47.562043, Longitude = -122.356734 }, // West Seattle Gymnastics & Parkour
            new {StreetAddress = "327 15th Ave E", City = "Seattle", State = "WA", PostalCode = "98112", Country = "USA", Latitude = 47.622729, Longitude = -122.312231 }, // Capitol Hill Strength & Conditioning
            new {StreetAddress = "2901 3rd Ave", City = "Seattle", State = "WA", PostalCode = "98121", Country = "USA", Latitude = 47.615104, Longitude = -122.346224 }, // Belltown Fitness
        };

        var clientId = "1f6e518e-2140-4107-8fd6-5433244581e7";
        var trainerId = "4b691f88-e924-4f4a-8b58-ef8569fddbc5";
        var createTimeUtc = DateTime.UtcNow;
        var updateTimeUtc = DateTime.UtcNow;
        var random = new Random();
        var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        var startDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo).Date;
        var endDate = startDate.AddYears(1);
        var appointmentHours = new[] { 9, 10, 11, 12, 13, 14, 15, 16 };

        var appointmentId = 1;
        var weeks = (int)Math.Ceiling((endDate - startDate).TotalDays / 7);
        for (var week = 0; week < weeks; week++)
        {
            var appointmentCount = random.Next(2, 4); // 2 or 3 appointments per week
            for (var i = 0; i < appointmentCount; i++)
            {
                var hour = appointmentHours[random.Next(appointmentHours.Length)];
                var duration = random.Next(1, 3); // 1 or 2 hours
                var randomDay = random.Next(1, 6); // Randomly select a weekday (1 = Monday, 5 = Friday)
                var appointmentDate = startDate.AddDays(week * 7 + randomDay);
                var startTimeUtc = TimeZoneInfo.ConvertTimeToUtc(new DateTime(appointmentDate.Year, appointmentDate.Month, appointmentDate.Day, hour, 0, 0), timeZoneInfo);
                var endTimeUtc = startTimeUtc.AddHours(duration);
                var address = addresses[random.Next(addresses.Length)];

                modelBuilder.Entity<Appointment>().HasData(new
                {
                    Id = appointmentId++,
                    ClientId = clientId,
                    TrainerId = trainerId,
                    CreateTimeUtc = createTimeUtc,
                    UpdateTimeUtc = updateTimeUtc,
                    StartTimeUtc = startTimeUtc,
                    EndTimeUtc = endTimeUtc,
                    StreetAddress = address.StreetAddress,
                    City = address.City,
                    State = address.State,
                    PostalCode = address.PostalCode,
                    Country = address.Country,
                    Latitude = address.Latitude,
                    Longitude = address.Longitude,
                    IsActive = true
                });
            }
        }
    }
}