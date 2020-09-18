using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BandAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Founded = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    MainGenre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: true),
                    BandId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "Id", "Founded", "MainGenre", "Name" },
                values: new object[,]
                {
                    { new Guid("3c0b8198-c7c5-4521-bdd1-cff61b98a05f"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy Metal", "Metallica" },
                    { new Guid("0ecca8db-3116-40e3-8178-7a45efa5edf7"), new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy Metal", "Guns n Roses" },
                    { new Guid("aece25e6-3785-4840-a7d7-3dd18f209dab"), new DateTime(1980, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy Metal", "Metallica" },
                    { new Guid("7d5577a5-abf1-430d-8591-58a50b58af80"), new DateTime(1980, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alternative", "Metallica" },
                    { new Guid("b5262e7b-4ffe-4a62-a2f5-7c4f090eeb40"), new DateTime(1980, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop", "A - ha " }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandId", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("6543677d-0262-4f6d-a06e-45a4fb9ac9b0"), new Guid("3c0b8198-c7c5-4521-bdd1-cff61b98a05f"), "One of the best heavy metal albums ever", "Master of puppets" },
                    { new Guid("9554622a-57cc-4a2d-a648-988e47a1fad4"), new Guid("0ecca8db-3116-40e3-8178-7a45efa5edf7"), "Amaznig Rock album with Raw sound", "Appetite for Destruction" },
                    { new Guid("fb89faa5-ffab-43f7-b8a6-19fa0a8ba213"), new Guid("aece25e6-3785-4840-a7d7-3dd18f209dab"), "Amaznig Rock album with Raw sound", "Huxy and griill" },
                    { new Guid("4ebfdc70-4d79-4c43-96a4-d0eda3cd6939"), new Guid("7d5577a5-abf1-430d-8591-58a50b58af80"), "Amaznig Rock album with Raw sound", "Huxy and griill" },
                    { new Guid("341b0995-b0cf-437f-9ba6-de15d0c430a4"), new Guid("b5262e7b-4ffe-4a62-a2f5-7c4f090eeb40"), "Jaleel is a good boy Rock album with Raw sound", "Jaleel and grill" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_BandId",
                table: "Albums",
                column: "BandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Bands");
        }
    }
}
