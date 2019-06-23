using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class ModifiedADUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEmployment",
                table: "ADUser",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndContract",
                table: "ADUser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEmployment",
                table: "ADUser");

            migrationBuilder.DropColumn(
                name: "EndContract",
                table: "ADUser");
        }
    }
}
