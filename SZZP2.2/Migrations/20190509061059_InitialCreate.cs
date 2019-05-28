using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SZZP2._2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    IDOffice = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOffice = table.Column<string>(nullable: true),
                    SymbolOffice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.IDOffice);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    IDPosition = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamePosition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.IDPosition);
                });

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
                name: "Status",
                columns: table => new
                {
                    IDStatus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.IDStatus);
                });

            migrationBuilder.CreateTable(
                name: "ADUser",
                columns: table => new
                {
                    NrSap = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    IDOffice = table.Column<int>(nullable: false),
                    IDDepartment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADUser", x => x.NrSap);
                    table.ForeignKey(
                        name: "FK_ADUser_Office_IDOffice",
                        column: x => x.IDOffice,
                        principalTable: "Office",
                        principalColumn: "IDOffice",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    IDDepartment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDOffice = table.Column<int>(nullable: false),
                    NameDepartment = table.Column<string>(nullable: true),
                    SymbolDeprtament = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.IDDepartment);
                    table.ForeignKey(
                        name: "FK_Department_Office_IDOffice",
                        column: x => x.IDOffice,
                        principalTable: "Office",
                        principalColumn: "IDOffice",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    IDEmployment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    NrSap = table.Column<string>(nullable: true),
                    DateEmployment = table.Column<DateTime>(nullable: false),
                    EndContract = table.Column<DateTime>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    IDOffice = table.Column<int>(nullable: false),
                    OfficeSymbol = table.Column<string>(nullable: true),
                    IDDepartment = table.Column<int>(nullable: false),
                    StatusEmployment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.IDEmployment);
                    table.ForeignKey(
                        name: "FK_Employment_Office_IDOffice",
                        column: x => x.IDOffice,
                        principalTable: "Office",
                        principalColumn: "IDOffice",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "APPUser",
                columns: table => new
                {
                    IDAPPUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IDRole = table.Column<int>(nullable: false),
                    ADUserNrSap = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "DataChange",
                columns: table => new
                {
                    IDDataChange = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateChange = table.Column<DateTime>(nullable: false),
                    NrSap = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    IDOffice = table.Column<int>(nullable: false),
                    IDDepartment = table.Column<int>(nullable: false),
                    NewIDOffice = table.Column<int>(nullable: true),
                    NewIDDepartament = table.Column<int>(nullable: true),
                    NewSurname = table.Column<string>(nullable: true),
                    StatusDataChange = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataChange", x => x.IDDataChange);
                    table.ForeignKey(
                        name: "FK_DataChange_ADUser_NrSap",
                        column: x => x.NrSap,
                        principalTable: "ADUser",
                        principalColumn: "NrSap",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dismissal",
                columns: table => new
                {
                    IDDismissal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NrSap = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: false),
                    IDOffice = table.Column<int>(nullable: false),
                    IDDepartment = table.Column<int>(nullable: false),
                    EndContract = table.Column<DateTime>(nullable: false),
                    StatusDismissal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dismissal", x => x.IDDismissal);
                    table.ForeignKey(
                        name: "FK_Dismissal_ADUser_NrSap",
                        column: x => x.NrSap,
                        principalTable: "ADUser",
                        principalColumn: "NrSap",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADUser_IDOffice",
                table: "ADUser",
                column: "IDOffice");

            migrationBuilder.CreateIndex(
                name: "IX_APPUser_ADUserNrSap",
                table: "APPUser",
                column: "ADUserNrSap");

            migrationBuilder.CreateIndex(
                name: "IX_APPUser_IDRole",
                table: "APPUser",
                column: "IDRole");

            migrationBuilder.CreateIndex(
                name: "IX_DataChange_NrSap",
                table: "DataChange",
                column: "NrSap");

            migrationBuilder.CreateIndex(
                name: "IX_Department_IDOffice",
                table: "Department",
                column: "IDOffice");

            migrationBuilder.CreateIndex(
                name: "IX_Dismissal_NrSap",
                table: "Dismissal",
                column: "NrSap");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_IDOffice",
                table: "Employment",
                column: "IDOffice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPUser");

            migrationBuilder.DropTable(
                name: "DataChange");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Dismissal");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "ADUser");

            migrationBuilder.DropTable(
                name: "Office");
        }
    }
}
