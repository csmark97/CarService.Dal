using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class MessageAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovedByClient",
                table: "Works");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ApprovedByClient",
                table: "Works",
                nullable: false,
                defaultValue: false);
        }
    }
}
