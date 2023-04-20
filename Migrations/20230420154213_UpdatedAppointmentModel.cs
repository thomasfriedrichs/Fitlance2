using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitlance.Migrations
{
    public partial class UpdatedAppointmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Address_AddressId",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "Fitlance");

            migrationBuilder.DropColumn(
                name: "AddressId",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "City",
                schema: "Fitlance",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "Fitlance",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                schema: "Fitlance",
                table: "Appointments",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                schema: "Fitlance",
                table: "Appointments",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                schema: "Fitlance",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                schema: "Fitlance",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                schema: "Fitlance",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "Fitlance",
                table: "Appointments",
                columns: new[] { "Id", "City", "ClientId", "Country", "CreateTimeUtc", "EndTimeUtc", "IsActive", "Latitude", "Longitude", "PostalCode", "StartTimeUtc", "State", "StreetAddress", "TrainerId", "UpdateTimeUtc", "UserId" },
                values: new object[,]
                {
                    { 1, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 4, 25, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2023, 4, 25, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 2, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 4, 23, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.688876999999998, -122.4029, "98117", new DateTime(2023, 4, 23, 16, 0, 0, 0, DateTimeKind.Utc), "WA", "8498 Seaview Pl NW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 3, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 4, 21, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 4, 21, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 4, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 4, 30, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2023, 4, 30, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 5, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 4, 29, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.706907999999999, -122.33473600000001, "98133", new DateTime(2023, 4, 29, 16, 0, 0, 0, DateTimeKind.Utc), "WA", "10740 Meridian Ave N Suite 107", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 6, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 9, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.682502399999997, -122.2639551, "98115", new DateTime(2023, 5, 9, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "7400 Sand Point Way NE", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 7, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 5, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 5, 5, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 8, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.583002999999998, -122.328509, "98134", new DateTime(2023, 5, 16, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "918 S Horton St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 9, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 14, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 5, 14, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 10, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 23, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.629367999999999, -122.35995, "98119", new DateTime(2023, 5, 23, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "250 W Highland Dr", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 11, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 19, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2023, 5, 19, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 12, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 5, 20, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 13, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 27, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.615104000000002, -122.34622400000001, "98121", new DateTime(2023, 5, 27, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "2901 3rd Ave", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 14, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 5, 26, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 5, 26, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 15, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 2, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.658023999999997, -122.40593699999999, "98199", new DateTime(2023, 6, 2, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "3801 Discovery Park Blvd", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 16, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 4, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.562043000000003, -122.356734, "98106", new DateTime(2023, 6, 4, 16, 0, 0, 0, DateTimeKind.Utc), "WA", "4219 W Marginal Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 17, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 4, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2023, 6, 4, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 18, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 12, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.706907999999999, -122.33473600000001, "98133", new DateTime(2023, 6, 12, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "10740 Meridian Ave N Suite 107", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 19, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 12, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2023, 6, 12, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 20, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 12, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.688876999999998, -122.4029, "98117", new DateTime(2023, 6, 12, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "8498 Seaview Pl NW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 21, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 18, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.562043000000003, -122.356734, "98106", new DateTime(2023, 6, 18, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "4219 W Marginal Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 22, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.629367999999999, -122.35995, "98119", new DateTime(2023, 6, 16, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "250 W Highland Dr", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 23, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 18, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.554881000000002, -122.249359, "98118", new DateTime(2023, 6, 18, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "5900 Lake Washington Blvd S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 24, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 25, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2023, 6, 25, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 25, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 6, 27, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2023, 6, 27, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 26, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.706907999999999, -122.33473600000001, "98133", new DateTime(2023, 7, 1, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "10740 Meridian Ave N Suite 107", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 27, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 3, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 7, 3, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 28, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 4, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.531377999999997, -122.39266499999999, "98136", new DateTime(2023, 7, 4, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "8011 Fauntleroy Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 29, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 8, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.646711000000003, -122.334383, "98103", new DateTime(2023, 7, 8, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "2101 N Northlake Way", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 30, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 11, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.646711000000003, -122.334383, "98103", new DateTime(2023, 7, 11, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "2101 N Northlake Way", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 31, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 14, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.621535999999999, -122.338284, "98109", new DateTime(2023, 7, 14, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "1002 Pontius Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 32, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 19, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.646711000000003, -122.334383, "98103", new DateTime(2023, 7, 18, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "2101 N Northlake Way", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 33, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 22, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2023, 7, 22, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 34, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 24, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.531377999999997, -122.39266499999999, "98136", new DateTime(2023, 7, 24, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "8011 Fauntleroy Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 35, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 31, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2023, 7, 31, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 36, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 30, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.629186900000001, -122.3424823, "98109", new DateTime(2023, 7, 30, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "100 Dexter Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 37, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 7, 30, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2023, 7, 30, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 38, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 5, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.581333000000001, -122.375772, "98116", new DateTime(2023, 8, 5, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "1702 Alki Ave SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 39, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 8, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.583002999999998, -122.328509, "98134", new DateTime(2023, 8, 8, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "918 S Horton St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 40, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 14, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.706907999999999, -122.33473600000001, "98133", new DateTime(2023, 8, 14, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "10740 Meridian Ave N Suite 107", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 41, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 12, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.658023999999997, -122.40593699999999, "98199", new DateTime(2023, 8, 12, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "3801 Discovery Park Blvd", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 42, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 11, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.646711000000003, -122.334383, "98103", new DateTime(2023, 8, 11, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "2101 N Northlake Way", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null }
                });

            migrationBuilder.InsertData(
                schema: "Fitlance",
                table: "Appointments",
                columns: new[] { "Id", "City", "ClientId", "Country", "CreateTimeUtc", "EndTimeUtc", "IsActive", "Latitude", "Longitude", "PostalCode", "StartTimeUtc", "State", "StreetAddress", "TrainerId", "UpdateTimeUtc", "UserId" },
                values: new object[,]
                {
                    { 43, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 22, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.562043000000003, -122.356734, "98106", new DateTime(2023, 8, 22, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "4219 W Marginal Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 44, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2023, 8, 19, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 45, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 25, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.554881000000002, -122.249359, "98118", new DateTime(2023, 8, 25, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "5900 Lake Washington Blvd S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 46, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 26, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2023, 8, 26, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 47, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 8, 26, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.639868999999997, -122.29495199999999, "98112", new DateTime(2023, 8, 26, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "2300 Arboretum Dr E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 48, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 1, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 9, 1, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 49, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 3, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2023, 9, 3, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 50, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 9, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 9, 9, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 51, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 9, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2023, 9, 9, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 52, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 9, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 9, 8, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 53, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 15, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.654747999999998, -122.342235, "98103", new DateTime(2023, 9, 15, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "4036 Stone Way N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 54, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 16, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 9, 16, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 55, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 22, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.531377999999997, -122.39266499999999, "98136", new DateTime(2023, 9, 22, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "8011 Fauntleroy Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 56, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 26, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.682502399999997, -122.2639551, "98115", new DateTime(2023, 9, 26, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "7400 Sand Point Way NE", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 57, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.629367999999999, -122.35995, "98119", new DateTime(2023, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "250 W Highland Dr", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 58, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 2, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 10, 2, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 59, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 1, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.562043000000003, -122.356734, "98106", new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Utc), "WA", "4219 W Marginal Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 60, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 9, 30, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.581333000000001, -122.375772, "98116", new DateTime(2023, 9, 30, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "1702 Alki Ave SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 61, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 6, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.658023999999997, -122.40593699999999, "98199", new DateTime(2023, 10, 6, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "3801 Discovery Park Blvd", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 62, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 9, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.706907999999999, -122.33473600000001, "98133", new DateTime(2023, 10, 9, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "10740 Meridian Ave N Suite 107", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 63, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 8, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.639868999999997, -122.29495199999999, "98112", new DateTime(2023, 10, 8, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "2300 Arboretum Dr E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 64, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2023, 10, 15, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 65, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.621535999999999, -122.338284, "98109", new DateTime(2023, 10, 15, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "1002 Pontius Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 66, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.629186900000001, -122.3424823, "98109", new DateTime(2023, 10, 22, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "100 Dexter Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 67, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 20, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 10, 20, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 68, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 22, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.531377999999997, -122.39266499999999, "98136", new DateTime(2023, 10, 22, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "8011 Fauntleroy Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 69, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 28, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2023, 10, 28, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 70, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 27, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.654747999999998, -122.342235, "98103", new DateTime(2023, 10, 27, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "4036 Stone Way N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 71, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 10, 31, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.581333000000001, -122.375772, "98116", new DateTime(2023, 10, 31, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1702 Alki Ave SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 72, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 8, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.562043000000003, -122.356734, "98106", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "WA", "4219 W Marginal Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 73, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 5, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.554881000000002, -122.249359, "98118", new DateTime(2023, 11, 5, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "5900 Lake Washington Blvd S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 74, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 12, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 11, 12, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 75, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 12, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 11, 12, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 76, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.688876999999998, -122.4029, "98117", new DateTime(2023, 11, 14, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "8498 Seaview Pl NW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 77, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 19, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.658023999999997, -122.40593699999999, "98199", new DateTime(2023, 11, 19, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "3801 Discovery Park Blvd", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 78, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 20, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.639868999999997, -122.29495199999999, "98112", new DateTime(2023, 11, 20, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "2300 Arboretum Dr E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 79, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 20, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.629186900000001, -122.3424823, "98109", new DateTime(2023, 11, 19, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "100 Dexter Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 80, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 25, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.615104000000002, -122.34622400000001, "98121", new DateTime(2023, 11, 25, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "2901 3rd Ave", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 81, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.639868999999997, -122.29495199999999, "98112", new DateTime(2023, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "2300 Arboretum Dr E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 82, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 5, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.654747999999998, -122.342235, "98103", new DateTime(2023, 12, 4, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "4036 Stone Way N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 83, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 2, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.682502399999997, -122.2639551, "98115", new DateTime(2023, 12, 2, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "7400 Sand Point Way NE", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 84, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 8, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.688876999999998, -122.4029, "98117", new DateTime(2023, 12, 8, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "8498 Seaview Pl NW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null }
                });

            migrationBuilder.InsertData(
                schema: "Fitlance",
                table: "Appointments",
                columns: new[] { "Id", "City", "ClientId", "Country", "CreateTimeUtc", "EndTimeUtc", "IsActive", "Latitude", "Longitude", "PostalCode", "StartTimeUtc", "State", "StreetAddress", "TrainerId", "UpdateTimeUtc", "UserId" },
                values: new object[,]
                {
                    { 85, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 11, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2023, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 86, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 15, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2023, 12, 15, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 87, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 17, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.531377999999997, -122.39266499999999, "98136", new DateTime(2023, 12, 17, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "8011 Fauntleroy Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 88, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 17, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.629186900000001, -122.3424823, "98109", new DateTime(2023, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "100 Dexter Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 89, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 24, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.621535999999999, -122.338284, "98109", new DateTime(2023, 12, 24, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "1002 Pontius Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 90, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 25, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.682502399999997, -122.2639551, "98115", new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), "WA", "7400 Sand Point Way NE", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 91, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.583002999999998, -122.328509, "98134", new DateTime(2023, 12, 24, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "918 S Horton St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 92, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.562043000000003, -122.356734, "98106", new DateTime(2024, 1, 1, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "4219 W Marginal Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 93, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 29, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.615104000000002, -122.34622400000001, "98121", new DateTime(2023, 12, 29, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "2901 3rd Ave", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 94, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 1, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.717564000000003, -122.287299, "98125", new DateTime(2024, 1, 1, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "3318 NE 125th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 95, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 7, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.658023999999997, -122.40593699999999, "98199", new DateTime(2024, 1, 7, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "3801 Discovery Park Blvd", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 96, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.688876999999998, -122.4029, "98117", new DateTime(2024, 1, 6, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "8498 Seaview Pl NW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 97, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 15, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.581333000000001, -122.375772, "98116", new DateTime(2024, 1, 14, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "1702 Alki Ave SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 98, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 15, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 99, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 13, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.706907999999999, -122.33473600000001, "98133", new DateTime(2024, 1, 13, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "10740 Meridian Ave N Suite 107", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 100, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 21, 2, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 101, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 23, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.554881000000002, -122.249359, "98118", new DateTime(2024, 1, 23, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "5900 Lake Washington Blvd S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 102, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 26, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.658023999999997, -122.40593699999999, "98199", new DateTime(2024, 1, 26, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "3801 Discovery Park Blvd", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 103, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 1, 27, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2024, 1, 27, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 104, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 4, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2024, 2, 4, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 105, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.621535999999999, -122.338284, "98109", new DateTime(2024, 2, 2, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "1002 Pontius Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 106, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 4, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.583002999999998, -122.328509, "98134", new DateTime(2024, 2, 4, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "918 S Horton St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 107, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 11, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.583002999999998, -122.328509, "98134", new DateTime(2024, 2, 11, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "918 S Horton St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 108, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 12, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.531377999999997, -122.39266499999999, "98136", new DateTime(2024, 2, 12, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "8011 Fauntleroy Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 109, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 19, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2024, 2, 19, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 110, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 16, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2024, 2, 16, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 111, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 26, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.629186900000001, -122.3424823, "98109", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), "WA", "100 Dexter Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 112, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2024, 2, 27, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 113, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 2, 23, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2024, 2, 23, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 114, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 4, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.622729, -122.312231, "98112", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Utc), "WA", "327 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 115, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.554881000000002, -122.249359, "98118", new DateTime(2024, 3, 4, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "5900 Lake Washington Blvd S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 116, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 4, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.621535999999999, -122.338284, "98109", new DateTime(2024, 3, 4, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "1002 Pontius Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 117, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 8, 19, 0, 0, 0, DateTimeKind.Utc), true, 47.629367999999999, -122.35995, "98119", new DateTime(2024, 3, 8, 18, 0, 0, 0, DateTimeKind.Utc), "WA", "250 W Highland Dr", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 118, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 12, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.654747999999998, -122.342235, "98103", new DateTime(2024, 3, 11, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "4036 Stone Way N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 119, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 17, 23, 0, 0, 0, DateTimeKind.Utc), true, 47.632389000000003, -122.31369100000001, "98112", new DateTime(2024, 3, 17, 21, 0, 0, 0, DateTimeKind.Utc), "WA", "1247 15th Ave E", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 120, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 15, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2024, 3, 15, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 121, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 24, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.661302999999997, -122.331084, "98103", new DateTime(2024, 3, 24, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1370 N 10th St", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 122, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 24, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2024, 3, 24, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 123, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.682502399999997, -122.2639551, "98115", new DateTime(2024, 3, 25, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "7400 Sand Point Way NE", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 124, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 30, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.682093999999999, -122.32705300000001, "98115", new DateTime(2024, 3, 30, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "7201 E Green Lake Dr N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 125, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 29, 21, 0, 0, 0, DateTimeKind.Utc), true, 47.621535999999999, -122.338284, "98109", new DateTime(2024, 3, 29, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "1002 Pontius Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 126, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 1, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.554881000000002, -122.249359, "98118", new DateTime(2024, 3, 31, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "5900 Lake Washington Blvd S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null }
                });

            migrationBuilder.InsertData(
                schema: "Fitlance",
                table: "Appointments",
                columns: new[] { "Id", "City", "ClientId", "Country", "CreateTimeUtc", "EndTimeUtc", "IsActive", "Latitude", "Longitude", "PostalCode", "StartTimeUtc", "State", "StreetAddress", "TrainerId", "UpdateTimeUtc", "UserId" },
                values: new object[,]
                {
                    { 127, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 8, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.562043000000003, -122.356734, "98106", new DateTime(2024, 4, 7, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "4219 W Marginal Way SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 128, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 9, 20, 0, 0, 0, DateTimeKind.Utc), true, 47.615104000000002, -122.34622400000001, "98121", new DateTime(2024, 4, 9, 19, 0, 0, 0, DateTimeKind.Utc), "WA", "2901 3rd Ave", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 129, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 8, 17, 0, 0, 0, DateTimeKind.Utc), true, 47.621535999999999, -122.338284, "98109", new DateTime(2024, 4, 8, 16, 0, 0, 0, DateTimeKind.Utc), "WA", "1002 Pontius Ave N", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 130, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 14, 1, 0, 0, 0, DateTimeKind.Utc), true, 47.646711000000003, -122.334383, "98103", new DateTime(2024, 4, 13, 23, 0, 0, 0, DateTimeKind.Utc), "WA", "2101 N Northlake Way", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 131, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 12, 22, 0, 0, 0, DateTimeKind.Utc), true, 47.545200999999999, -122.313343, "98108", new DateTime(2024, 4, 12, 20, 0, 0, 0, DateTimeKind.Utc), "WA", "6109 13th Ave S", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 132, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), true, 47.581333000000001, -122.375772, "98116", new DateTime(2024, 4, 19, 22, 0, 0, 0, DateTimeKind.Utc), "WA", "1702 Alki Ave SW", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null },
                    { 133, "Seattle", "1f6e518e-2140-4107-8fd6-5433244581e7", "USA", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 23, 18, 0, 0, 0, DateTimeKind.Utc), true, 47.706907999999999, -122.33473600000001, "98133", new DateTime(2024, 4, 23, 17, 0, 0, 0, DateTimeKind.Utc), "WA", "10740 Meridian Ave N Suite 107", "4b691f88-e924-4f4a-8b58-ef8569fddbc5", new DateTime(2023, 4, 20, 15, 42, 13, 630, DateTimeKind.Utc).AddTicks(8923), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "Fitlance",
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DropColumn(
                name: "City",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Country",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Latitude",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Longitude",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "State",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                schema: "Fitlance",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                schema: "Fitlance",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "Fitlance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_AddressId",
                schema: "Fitlance",
                table: "Appointments",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Address_AddressId",
                schema: "Fitlance",
                table: "Appointments",
                column: "AddressId",
                principalSchema: "Fitlance",
                principalTable: "Address",
                principalColumn: "Id");
        }
    }
}
