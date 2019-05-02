using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class IntorduceOpeningDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndSaturday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "EndSunday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "StartSaturday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "StartSunday",
                table: "Openings");

            migrationBuilder.RenameColumn(
                name: "StartWednesday",
                table: "Openings",
                newName: "Wednesday_Start");

            migrationBuilder.RenameColumn(
                name: "StartTuesday",
                table: "Openings",
                newName: "Wednesday_End");

            migrationBuilder.RenameColumn(
                name: "StartThursday",
                table: "Openings",
                newName: "Tuesday_Start");

            migrationBuilder.RenameColumn(
                name: "StartMonday",
                table: "Openings",
                newName: "Tuesday_End");

            migrationBuilder.RenameColumn(
                name: "StartFriday",
                table: "Openings",
                newName: "Thursday_Start");

            migrationBuilder.RenameColumn(
                name: "EndWednesday",
                table: "Openings",
                newName: "Thursday_End");

            migrationBuilder.RenameColumn(
                name: "EndTuesday",
                table: "Openings",
                newName: "Sunday_Start");

            migrationBuilder.RenameColumn(
                name: "EndThursday",
                table: "Openings",
                newName: "Sunday_End");

            migrationBuilder.RenameColumn(
                name: "EndMonday",
                table: "Openings",
                newName: "Saturday_Start");

            migrationBuilder.RenameColumn(
                name: "EndFriday",
                table: "Openings",
                newName: "Saturday_End");

            migrationBuilder.AddColumn<DateTime>(
                name: "Friday_End",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Friday_Start",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Monday_End",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Monday_Start",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friday_End",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "Friday_Start",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "Monday_End",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "Monday_Start",
                table: "Openings");

            migrationBuilder.RenameColumn(
                name: "Wednesday_Start",
                table: "Openings",
                newName: "StartWednesday");

            migrationBuilder.RenameColumn(
                name: "Wednesday_End",
                table: "Openings",
                newName: "StartTuesday");

            migrationBuilder.RenameColumn(
                name: "Tuesday_Start",
                table: "Openings",
                newName: "StartThursday");

            migrationBuilder.RenameColumn(
                name: "Tuesday_End",
                table: "Openings",
                newName: "StartMonday");

            migrationBuilder.RenameColumn(
                name: "Thursday_Start",
                table: "Openings",
                newName: "StartFriday");

            migrationBuilder.RenameColumn(
                name: "Thursday_End",
                table: "Openings",
                newName: "EndWednesday");

            migrationBuilder.RenameColumn(
                name: "Sunday_Start",
                table: "Openings",
                newName: "EndTuesday");

            migrationBuilder.RenameColumn(
                name: "Sunday_End",
                table: "Openings",
                newName: "EndThursday");

            migrationBuilder.RenameColumn(
                name: "Saturday_Start",
                table: "Openings",
                newName: "EndMonday");

            migrationBuilder.RenameColumn(
                name: "Saturday_End",
                table: "Openings",
                newName: "EndFriday");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSaturday",
                table: "Openings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSunday",
                table: "Openings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartSaturday",
                table: "Openings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartSunday",
                table: "Openings",
                nullable: true);
        }
    }
}
