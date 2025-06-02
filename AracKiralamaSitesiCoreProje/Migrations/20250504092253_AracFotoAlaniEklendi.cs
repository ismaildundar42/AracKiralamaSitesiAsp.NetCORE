using Microsoft.EntityFrameworkCore.Migrations;

namespace AracKiralamaSitesiCoreProje.Migrations
{
    public partial class AracFotoAlaniEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AracFoto",
                table: "aracs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracFoto",
                table: "aracs");
        }
    }
}
