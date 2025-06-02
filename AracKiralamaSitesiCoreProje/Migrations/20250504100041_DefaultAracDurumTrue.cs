using Microsoft.EntityFrameworkCore.Migrations;

namespace AracKiralamaSitesiCoreProje.Migrations
{
    public partial class DefaultAracDurumTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "AracDurum",
                table: "aracs",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "AracDurum",
                table: "aracs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);
        }
    }
}
