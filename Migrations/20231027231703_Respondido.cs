using Microsoft.EntityFrameworkCore.Migrations;

namespace Atv3._1.Migrations
{
    public partial class Respondido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Respondido",
                table: "Contatos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Respondido",
                table: "Contatos");
        }
    }
}
