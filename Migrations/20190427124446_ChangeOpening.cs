using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class ChangeOpening : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SundayClosed",
                table: "Openings",
                newName: "SundayOpen");

            migrationBuilder.RenameColumn(
                name: "SaturdayClosed",
                table: "Openings",
                newName: "SaturdayOpen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SundayOpen",
                table: "Openings",
                newName: "SundayClosed");

            migrationBuilder.RenameColumn(
                name: "SaturdayOpen",
                table: "Openings",
                newName: "SaturdayClosed");
        }
    }
}
