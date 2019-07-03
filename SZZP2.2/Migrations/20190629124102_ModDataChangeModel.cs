using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class ModDataChangeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionsIDPosition",
                table: "DataChange",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusesIDStatus",
                table: "DataChange",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_IDOffice",
                table: "DataChange",
                column: "IDOffice");

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_PositionsIDPosition",
                table: "DataChange",
                column: "PositionsIDPosition");

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_StatusesIDStatus",
                table: "DataChange",
                column: "StatusesIDStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_DataChange_Office_IDOffice",
                table: "DataChange",
                column: "IDOffice",
                principalTable: "Office",
                principalColumn: "IDOffice",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataChange_Position_PositionsIDPosition",
                table: "DataChange",
                column: "PositionsIDPosition",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataChange_Status_StatusesIDStatus",
                table: "DataChange",
                column: "StatusesIDStatus",
                principalTable: "Status",
                principalColumn: "IDStatus",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Office_IDOffice",
                table: "DataChange");

            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Position_PositionsIDPosition",
                table: "DataChange");

            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Status_StatusesIDStatus",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_IDOffice",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_PositionsIDPosition",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_StatusesIDStatus",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "PositionsIDPosition",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "StatusesIDStatus",
                table: "DataChange");
        }
    }
}
