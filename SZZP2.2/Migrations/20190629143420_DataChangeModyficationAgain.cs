using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class DataChangeModyficationAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Position_IDPosition",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_IDPosition",
                table: "DataChange");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
