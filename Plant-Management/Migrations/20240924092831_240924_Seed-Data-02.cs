using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plant_Management.Migrations
{
    /// <inheritdoc />
    public partial class _240924_SeedData02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlantTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1", "Succulent" },
                    { "2", "Fern" }
                });

            migrationBuilder.InsertData(
                table: "SoilTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { "1", "", "Sandy" },
                    { "2", "", "Loamy" }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "CommonName", "Cultivar", "CustomName", "DateCreated", "DateExpired", "DateUpdated", "Genus", "Height", "HumidityPreference", "IsToxic", "LightLevel", "LocationId", "MaxTemperature", "MinTemperature", "MoistureLevel", "PlantTypeId", "SoilTypeId", "Species", "Width" },
                values: new object[] { "1", "Fiddle Leaf Fig", "Standard", "Fiddle Leaf Fig", new DateTime(2024, 9, 24, 9, 28, 31, 103, DateTimeKind.Utc).AddTicks(6460), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 9, 28, 31, 103, DateTimeKind.Utc).AddTicks(6460), "Ficus", 1.5, "Medium", true, 75.0, null, 25.0, 18.0, 3.0, "1", "1", "Lyrata", 1.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "SoilTypes",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "SoilTypes",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
