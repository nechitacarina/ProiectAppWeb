using Microsoft.EntityFrameworkCore.Migrations;

namespace Nechita_Carina_Proiect.Migrations
{
    public partial class modificari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "numar_cont",
                table: "Cont",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CNP",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numar_cont",
                table: "Cont");

            migrationBuilder.DropColumn(
                name: "CNP",
                table: "Client");
        }
    }
}
