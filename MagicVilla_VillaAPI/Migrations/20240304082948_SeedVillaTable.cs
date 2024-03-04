using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 3, 4, 13, 29, 48, 644, DateTimeKind.Local).AddTicks(5030), "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.", "", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2024, 3, 4, 13, 29, 48, 644, DateTimeKind.Local).AddTicks(5049), "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.", "", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2024, 3, 4, 13, 29, 48, 644, DateTimeKind.Local).AddTicks(5052), "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.", "", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
