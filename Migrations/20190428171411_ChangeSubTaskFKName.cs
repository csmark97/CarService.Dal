using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class ChangeSubTaskFKName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Users_CompanyId",
                table: "SubTasks");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "SubTasks",
                newName: "CompanyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SubTasks_CompanyId",
                table: "SubTasks",
                newName: "IX_SubTasks_CompanyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Users_CompanyUserId",
                table: "SubTasks",
                column: "CompanyUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Users_CompanyUserId",
                table: "SubTasks");

            migrationBuilder.RenameColumn(
                name: "CompanyUserId",
                table: "SubTasks",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_SubTasks_CompanyUserId",
                table: "SubTasks",
                newName: "IX_SubTasks_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Users_CompanyId",
                table: "SubTasks",
                column: "CompanyId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
