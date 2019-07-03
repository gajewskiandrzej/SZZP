using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class ModDataChangeModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Position_PositionsIDPosition",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_PositionsIDPosition",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "PositionsIDPosition",
                table: "DataChange");

            migrationBuilder.AddColumn<int>(
                name: "IDPosition",
                table: "DataChange",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_IDPosition",
                table: "DataChange",
                column: "IDPosition");

            migrationBuilder.AddForeignKey(
                name: "FK_DataChange_Position_IDPosition",
                table: "DataChange",
                column: "IDPosition",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Position_IDPosition",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_IDPosition",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "IDPosition",
                table: "DataChange");

            migrationBuilder.AddColumn<int>(
                name: "PositionsIDPosition",
                table: "DataChange",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_PositionsIDPosition",
                table: "DataChange",
                column: "PositionsIDPosition");

            migrationBuilder.AddForeignKey(
                name: "FK_DataChange_Position_PositionsIDPosition",
                table: "DataChange",
                column: "PositionsIDPosition",
                principalTable: "Position",
                principalColumn: "IDPosition",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
