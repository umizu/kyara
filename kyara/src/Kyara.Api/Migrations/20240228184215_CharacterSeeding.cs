using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kyara.Api.Migrations
{
    /// <inheritdoc />
    public partial class CharacterSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Image", "Name", "Rating" },
                values: new object[,]
                {
                    { new Guid("7dbc50f9-f4a6-4f0d-a192-4d1f58e5928c"), "https://i1.sndcdn.com/artworks-000133617614-ywuyai-t500x500.jpg", "Akame", 4 },
                    { new Guid("9873b8fb-561b-4492-aa7f-03d3a7202c45"), "https://image.civitai.com/xG1nkqKTMzGDvpLrqFT7WA/2948a0a5-4bde-4290-94ed-edf158befd07/width=450/Isla0.jpeg", "Isla", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("7dbc50f9-f4a6-4f0d-a192-4d1f58e5928c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("9873b8fb-561b-4492-aa7f-03d3a7202c45"));
        }
    }
}
