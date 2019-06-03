using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class AppUserRoleRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPUser");

            migrationBuilder.DropTable(
                name: "Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    IDRole = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.IDRole);
                });

            migrationBuilder.CreateTable(
                name: "APPUser",
                columns: table => new
                {
                    IDAPPUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ADUserNrSap = table.Column<string>(nullable: true),
                    IDRole = table.Column<int>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPUser", x => x.IDAPPUser);
                    table.ForeignKey(
                        name: "FK_APPUser_ADUser_ADUserNrSap",
                        column: x => x.ADUserNrSap,
                        principalTable: "ADUser",
                        principalColumn: "NrSap",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_APPUser_Role_IDRole",
                        column: x => x.IDRole,
                        principalTable: "Role",
                        principalColumn: "IDRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APPUser_ADUserNrSap",
                table: "APPUser",
                column: "ADUserNrSap");

            migrationBuilder.CreateIndex(
                name: "IX_APPUser_IDRole",
                table: "APPUser",
                column: "IDRole");
        }
    }
}
