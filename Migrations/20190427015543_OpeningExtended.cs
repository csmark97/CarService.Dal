using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class OpeningExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wednesday",
                table: "Openings",
                newName: "StartWednesday");

            migrationBuilder.RenameColumn(
                name: "Tuesday",
                table: "Openings",
                newName: "StartTuesday");

            migrationBuilder.RenameColumn(
                name: "Thursday",
                table: "Openings",
                newName: "StartThursday");

            migrationBuilder.RenameColumn(
                name: "Sunday",
                table: "Openings",
                newName: "StartSunday");

            migrationBuilder.RenameColumn(
                name: "Saturday",
                table: "Openings",
                newName: "StartSaturday");

            migrationBuilder.RenameColumn(
                name: "Monday",
                table: "Openings",
                newName: "StartMonday");

            migrationBuilder.RenameColumn(
                name: "Friday",
                table: "Openings",
                newName: "StartFriday");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndFriday",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndMonday",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSaturday",
                table: "Openings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSunday",
                table: "Openings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndThursday",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTuesday",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndWednesday",
                table: "Openings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndFriday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "EndMonday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "EndSaturday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "EndSunday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "EndThursday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "EndTuesday",
                table: "Openings");

            migrationBuilder.DropColumn(
                name: "EndWednesday",
                table: "Openings");

            migrationBuilder.RenameColumn(
                name: "StartWednesday",
                table: "Openings",
                newName: "Wednesday");

            migrationBuilder.RenameColumn(
                name: "StartTuesday",
                table: "Openings",
                newName: "Tuesday");

            migrationBuilder.RenameColumn(
                name: "StartThursday",
                table: "Openings",
                newName: "Thursday");

            migrationBuilder.RenameColumn(
                name: "StartSunday",
                table: "Openings",
                newName: "Sunday");

            migrationBuilder.RenameColumn(
                name: "StartSaturday",
                table: "Openings",
                newName: "Saturday");

            migrationBuilder.RenameColumn(
                name: "StartMonday",
                table: "Openings",
                newName: "Monday");

            migrationBuilder.RenameColumn(
                name: "StartFriday",
                table: "Openings",
                newName: "Friday");
        }
    }
}
