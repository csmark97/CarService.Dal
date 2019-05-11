using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class MessageAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ApprovedByClient",
                table: "Works",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApprovedByClient",
                table: "Works",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
