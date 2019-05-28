using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class ChangeRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusEmployment",
                table: "Employment");

            migrationBuilder.AddColumn<int>(
                name: "IDPosition",
                table: "Employment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDStatus",
                table: "Employment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employment_IDPosition",
                table: "Employment",
                column: "IDPosition");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_IDStatus",
                table: "Employment",
                column: "IDStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_Position_IDPosition",
                table: "Employment",
                column: "IDPosition",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_Status_IDStatus",
                table: "Employment",
                column: "IDStatus",
                principalTable: "Status",
                principalColumn: "IDStatus",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employment_Position_IDPosition",
                table: "Employment");

            migrationBuilder.DropForeignKey(
                name: "FK_Employment_Status_IDStatus",
                table: "Employment");

            migrationBuilder.DropIndex(
                name: "IX_Employment_IDPosition",
                table: "Employment");

            migrationBuilder.DropIndex(
                name: "IX_Employment_IDStatus",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "IDPosition",
                table: "Employment");

            migrationBuilder.DropColumn(
                name: "IDStatus",
                table: "Employment");

            migrationBuilder.AddColumn<string>(
                name: "StatusEmployment",
                table: "Employment",
                nullable: true);
        }
    }
}
