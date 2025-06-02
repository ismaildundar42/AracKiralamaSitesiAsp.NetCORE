using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AracKiralamaSitesiCoreProje.Migrations
{
    public partial class FixKiralamaKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KiralananArac",
                table: "musteris");

            migrationBuilder.AddColumn<string>(
                name: "MusteriSifre",
                table: "musteris",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "kiralamas",
                columns: table => new
                {
                    KiraID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KiraBaslangic = table.Column<DateTime>(nullable: false),
                    KiraBitis = table.Column<DateTime>(nullable: false),
                    MusteriId = table.Column<int>(nullable: false),
                    AracId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kiralamas", x => x.KiraID);
                    table.ForeignKey(
                        name: "FK_kiralamas_aracs_AracId",
                        column: x => x.AracId,
                        principalTable: "aracs",
                        principalColumn: "AracId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kiralamas_musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "musteris",
                        principalColumn: "MusteriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kiralamas_AracId",
                table: "kiralamas",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_kiralamas_MusteriId",
                table: "kiralamas",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kiralamas");

            migrationBuilder.DropColumn(
                name: "MusteriSifre",
                table: "musteris");

            migrationBuilder.AddColumn<int>(
                name: "KiralananArac",
                table: "musteris",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
