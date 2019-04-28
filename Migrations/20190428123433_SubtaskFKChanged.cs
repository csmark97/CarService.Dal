using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class SubtaskFKChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Users_CompanyId1",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_CompanyId1",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "CompanyId1",
                table: "SubTasks");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyId",
                table: "SubTasks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_CompanyId",
                table: "SubTasks",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Users_CompanyId",
                table: "SubTasks",
                column: "CompanyId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Users_CompanyId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_CompanyId",
                table: "SubTasks");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "SubTasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyId1",
                table: "SubTasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_CompanyId1",
                table: "SubTasks",
                column: "CompanyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Users_CompanyId1",
                table: "SubTasks",
                column: "CompanyId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
