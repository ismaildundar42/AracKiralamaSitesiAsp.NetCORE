using Microsoft.EntityFrameworkCore.Migrations;

namespace AracKiralamaSitesiCoreProje.Migrations
{
    public partial class ismail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aracs",
                columns: table => new
                {
                    AracId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracMarka = table.Column<string>(nullable: true),
                    AracModel = table.Column<string>(nullable: true),
                    AracPlaka = table.Column<string>(nullable: true),
                    AracYakit = table.Column<string>(nullable: true),
                    AracGunlukFiyat = table.Column<int>(nullable: false),
                    AracDurum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracs", x => x.AracId);
                });

            migrationBuilder.CreateTable(
                name: "musteris",
                columns: table => new
                {
                    MusteriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdSoyad = table.Column<string>(nullable: true),
                    MusteriTelefon = table.Column<string>(nullable: true),
                    MusteriTc = table.Column<string>(nullable: true),
                    KiralananArac = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musteris", x => x.MusteriId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aracs");

            migrationBuilder.DropTable(
                name: "musteris");
        }
    }
}
