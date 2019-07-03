using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class modDataChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewIDDepartament",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "NewIDOffice",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "NewSurname",
                table: "DataChange");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewIDDepartament",
                table: "DataChange",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NewIDOffice",
                table: "DataChange",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NewSurname",
                table: "DataChange",
                nullable: true);
        }
    }
}
