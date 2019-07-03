using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class DataChangeModyfication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Status_StatusesIDStatus",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_StatusesIDStatus",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "StatusDataChange",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "StatusesIDStatus",
                table: "DataChange");

            migrationBuilder.AddColumn<int>(
                name: "IDStatus",
                table: "DataChange",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_IDStatus",
                table: "DataChange",
                column: "IDStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_DataChange_Status_IDStatus",
                table: "DataChange",
                column: "IDStatus",
                principalTable: "Status",
                principalColumn: "IDStatus",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataChange_Status_IDStatus",
                table: "DataChange");

            migrationBuilder.DropIndex(
                name: "IX_DataChange_IDStatus",
                table: "DataChange");

            migrationBuilder.DropColumn(
                name: "IDStatus",
                table: "DataChange");

            migrationBuilder.AddColumn<string>(
                name: "StatusDataChange",
                table: "DataChange",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusesIDStatus",
                table: "DataChange",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_StatusesIDStatus",
                table: "DataChange",
                column: "StatusesIDStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_DataChange_Status_StatusesIDStatus",
                table: "DataChange",
                column: "StatusesIDStatus",
                principalTable: "Status",
                principalColumn: "IDStatus",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
