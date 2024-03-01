using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kyara.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Image", "Name", "Rating" },
                values: new object[,]
                {
                    { new Guid("0779e90d-105e-42bd-868a-47abf2c07746"), "https://s4.anilist.co/file/anilistcdn/character/large/b63351-0WmsDENpiscp.png", "Akame", 5 },
                    { new Guid("15f490cc-73ec-4adb-80b8-c6d9db9325eb"), "https://s4.anilist.co/file/anilistcdn/character/large/b2707-YKWmn4q87oF8.png", "Trunks", 5 },
                    { new Guid("16e9e9ab-7590-4509-832e-aa61589e5b0b"), "https://s4.anilist.co/file/anilistcdn/character/large/b168800-eb3FqWq0IdyV.png", "Rose", 3 },
                    { new Guid("18167d54-a09a-4e36-9959-036dc0966f83"), "https://s4.anilist.co/file/anilistcdn/character/large/b162249-eJRpBIC5lAZX.png", "Epsilon", 4 },
                    { new Guid("1e270e4d-427b-48bd-885d-84e0b3c798aa"), "https://s4.anilist.co/file/anilistcdn/character/large/b2093-kdFZhqcNSsqW.png", "Gohan", 5 },
                    { new Guid("2dfffbc5-b887-4769-8e38-b8136f3b58cf"), "https://s4.anilist.co/file/anilistcdn/character/large/b678-2YCe13F0tFos.jpg", "Bulma", 5 },
                    { new Guid("3d03da0c-9f3a-4443-957c-52e532bcdcc3"), "https://s4.anilist.co/file/anilistcdn/character/large/b913-NIFkKazWM8VO.png", "Vegeta", 5 },
                    { new Guid("42c47fb4-0676-4ef5-a7bc-fdcc8ff368c4"), "https://s4.anilist.co/file/anilistcdn/character/large/b2111-9XqkV0tpjRPB.png", "Videl", 4 },
                    { new Guid("46b9b5ac-39ff-471e-b8a8-0300b6c94f0c"), "https://s4.anilist.co/file/anilistcdn/character/large/b162248-57Xgk6EmwKRQ.png", "Delta", 5 },
                    { new Guid("615e0cc5-9149-45b5-b0b6-038061d45180"), "https://s4.anilist.co/file/anilistcdn/character/large/b168798-IrHBKh5xbRsr.png", "Claire", 3 },
                    { new Guid("6b18936f-4f87-4899-92ab-84f456f0b063"), "https://s4.anilist.co/file/anilistcdn/character/large/b162247-R6OrAuT1FwL4.png", "Beta", 5 },
                    { new Guid("6d5ff261-43cc-4aa1-9bcd-d767794cd663"), "https://s4.anilist.co/file/anilistcdn/character/large/246-wsRRr6z1kii8.png", "Goku", 5 },
                    { new Guid("751d5173-7728-4735-8517-a40cbb26da78"), "https://s4.anilist.co/file/anilistcdn/character/large/b162246-IbbxkhNJFDN5.png", "Alpha", 5 },
                    { new Guid("99db1b80-4aec-4b43-a558-ab8ba7962818"), "https://s4.anilist.co/file/anilistcdn/character/large/b2159-qtEuMYyOUkwY.jpg", "Krillen", 4 },
                    { new Guid("a95c4646-bc14-4ade-b9f9-4971782a4369"), "https://s4.anilist.co/file/anilistcdn/character/large/b136837-3WR22FYet8Hv.jpg", "Cid", 5 },
                    { new Guid("b0da1040-f4f9-4600-8c53-cc5cdc2cf1af"), "https://s4.anilist.co/file/anilistcdn/character/large/b88753-RO3lBZgzwdJF.jpg", "Isla", 5 },
                    { new Guid("db8a5f06-8613-43c0-96cb-dffc60b48e65"), "https://s4.anilist.co/file/anilistcdn/character/large/b168799-uAsWFrrfqxTN.png", "Alexia", 3 },
                    { new Guid("e151614b-de3a-447d-a574-31a0d45dbe91"), "https://s4.anilist.co/file/anilistcdn/character/large/b914-KuS8AWjqBrqa.jpg", "Piccolo", 3 },
                    { new Guid("fb1fd69d-8c1a-4d9f-893a-d57d51e66188"), "https://s4.anilist.co/file/anilistcdn/character/large/1012.jpg", "Boo", 3 },
                    { new Guid("fe2c0eb5-548f-4b3e-9338-811340b20777"), "https://s4.anilist.co/file/anilistcdn/character/large/b162245-x86QMM6nOj75.png", "Gamma", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
