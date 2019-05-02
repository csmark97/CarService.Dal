using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class StatesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Requested" },
                    { 2, "Accepted" },
                    { 3, "Begun" },
                    { 4, "Paid" },
                    { 5, "Finished" },
                    { 6, "PaidAndFinished" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
