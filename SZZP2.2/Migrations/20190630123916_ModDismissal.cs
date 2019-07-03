using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class ModDismissal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusDismissal",
                table: "Dismissal");

            migrationBuilder.AddColumn<int>(
                name: "IDStatus",
                table: "Dismissal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dismissal_IDOffice",
                table: "Dismissal",
                column: "IDOffice");

            migrationBuilder.CreateIndex(
                name: "IX_Dismissal_IDStatus",
                table: "Dismissal",
                column: "IDStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_Dismissal_Office_IDOffice",
                table: "Dismissal",
                column: "IDOffice",
                principalTable: "Office",
                principalColumn: "IDOffice",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dismissal_Status_IDStatus",
                table: "Dismissal",
                column: "IDStatus",
                principalTable: "Status",
                principalColumn: "IDStatus",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dismissal_Office_IDOffice",
                table: "Dismissal");

            migrationBuilder.DropForeignKey(
                name: "FK_Dismissal_Status_IDStatus",
                table: "Dismissal");

            migrationBuilder.DropIndex(
                name: "IX_Dismissal_IDOffice",
                table: "Dismissal");

            migrationBuilder.DropIndex(
                name: "IX_Dismissal_IDStatus",
                table: "Dismissal");

            migrationBuilder.DropColumn(
                name: "IDStatus",
                table: "Dismissal");

            migrationBuilder.AddColumn<string>(
                name: "StatusDismissal",
                table: "Dismissal",
                nullable: true);
        }
    }
}
