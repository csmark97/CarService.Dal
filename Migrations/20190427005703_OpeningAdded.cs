using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Dal.Migrations
{
    public partial class OpeningAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpeningId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Openings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Monday = table.Column<DateTime>(nullable: false),
                    Tuesday = table.Column<DateTime>(nullable: false),
                    Wednesday = table.Column<DateTime>(nullable: false),
                    Thursday = table.Column<DateTime>(nullable: false),
                    Friday = table.Column<DateTime>(nullable: false),
                    Saturday = table.Column<DateTime>(nullable: false),
                    Sunday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Openings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OpeningId",
                table: "Users",
                column: "OpeningId",
                unique: true,
                filter: "[OpeningId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Openings_OpeningId",
                table: "Users",
                column: "OpeningId",
                principalTable: "Openings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Openings_OpeningId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Openings");

            migrationBuilder.DropIndex(
                name: "IX_Users_OpeningId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OpeningId",
                table: "Users");
        }
    }
}
