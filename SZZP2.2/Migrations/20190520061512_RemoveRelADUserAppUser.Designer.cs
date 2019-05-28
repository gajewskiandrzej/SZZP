﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SZZP2._2.Data;

namespace SZZP2._2.Migrations
{
    [DbContext(typeof(SZZPContext))]
    [Migration("20190520061512_RemoveRelADUserAppUser")]
    partial class RemoveRelADUserAppUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SZZP2._2.Models.ADUser", b =>
                {
                    b.Property<string>("NrSap")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDDepartment");

                    b.Property<int>("IDOffice");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("NrSap");

                    b.HasIndex("IDOffice");

                    b.ToTable("ADUser");
                });

            modelBuilder.Entity("SZZP2._2.Models.APPUser", b =>
                {
                    b.Property<int>("IDAPPUser")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADUserNrSap");

                    b.Property<int>("IDRole");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("IDAPPUser");

                    b.HasIndex("ADUserNrSap");

                    b.HasIndex("IDRole");

                    b.ToTable("APPUser");
                });

            modelBuilder.Entity("SZZP2._2.Models.DataChange", b =>
                {
                    b.Property<int>("IDDataChange")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateChange");

                    b.Property<int>("IDDepartment");

                    b.Property<int>("IDOffice");

                    b.Property<string>("Name");

                    b.Property<int?>("NewIDDepartament");

                    b.Property<int?>("NewIDOffice");

                    b.Property<string>("NewSurname");

                    b.Property<string>("NrSap");

                    b.Property<string>("StatusDataChange");

                    b.Property<string>("Surname");

                    b.HasKey("IDDataChange");

                    b.HasIndex("NrSap");

                    b.ToTable("DataChange");
                });

            modelBuilder.Entity("SZZP2._2.Models.Department", b =>
                {
                    b.Property<int>("IDDepartment")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IDOffice");

                    b.Property<string>("NameDepartment");

                    b.Property<string>("SymbolDeprtament");

                    b.HasKey("IDDepartment");

                    b.HasIndex("IDOffice");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SZZP2._2.Models.Dismissal", b =>
                {
                    b.Property<int>("IDDismissal")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndContract");

                    b.Property<int>("IDDepartment");

                    b.Property<int>("IDOffice");

                    b.Property<string>("Name");

                    b.Property<string>("NrSap");

                    b.Property<int>("Position");

                    b.Property<string>("StatusDismissal");

                    b.Property<string>("Surname");

                    b.HasKey("IDDismissal");

                    b.HasIndex("NrSap");

                    b.ToTable("Dismissal");
                });

            modelBuilder.Entity("SZZP2._2.Models.Employment", b =>
                {
                    b.Property<int>("IDEmployment")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateEmployment");

                    b.Property<DateTime?>("EndContract");

                    b.Property<int>("IDDepartment");

                    b.Property<int>("IDOffice");

                    b.Property<int>("IDPosition");

                    b.Property<int>("IDStatus");

                    b.Property<string>("Name");

                    b.Property<string>("NrSap");

                    b.Property<string>("OfficeSymbol");

                    b.Property<string>("Surname");

                    b.HasKey("IDEmployment");

                    b.HasIndex("IDOffice");

                    b.HasIndex("IDPosition");

                    b.HasIndex("IDStatus");

                    b.ToTable("Employment");
                });

            modelBuilder.Entity("SZZP2._2.Models.Office", b =>
                {
                    b.Property<int>("IDOffice")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOffice");

                    b.Property<string>("SymbolOffice");

                    b.HasKey("IDOffice");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("SZZP2._2.Models.Position", b =>
                {
                    b.Property<int>("IDPosition")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NamePosition");

                    b.HasKey("IDPosition");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("SZZP2._2.Models.Role", b =>
                {
                    b.Property<int>("IDRole")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameRole");

                    b.HasKey("IDRole");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("SZZP2._2.Models.Status", b =>
                {
                    b.Property<int>("IDStatus")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameStatus");

                    b.HasKey("IDStatus");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("SZZP2._2.Models.ADUser", b =>
                {
                    b.HasOne("SZZP2._2.Models.Office", "Office")
                        .WithMany("ADUsers")
                        .HasForeignKey("IDOffice")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SZZP2._2.Models.APPUser", b =>
                {
                    b.HasOne("SZZP2._2.Models.ADUser")
                        .WithMany("APPUsers")
                        .HasForeignKey("ADUserNrSap");

                    b.HasOne("SZZP2._2.Models.Role", "Roles")
                        .WithMany("APPUsers")
                        .HasForeignKey("IDRole")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SZZP2._2.Models.DataChange", b =>
                {
                    b.HasOne("SZZP2._2.Models.ADUser", "ADUsers")
                        .WithMany("DataChanges")
                        .HasForeignKey("NrSap");
                });

            modelBuilder.Entity("SZZP2._2.Models.Department", b =>
                {
                    b.HasOne("SZZP2._2.Models.Office", "Offices")
                        .WithMany("Departments")
                        .HasForeignKey("IDOffice")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SZZP2._2.Models.Dismissal", b =>
                {
                    b.HasOne("SZZP2._2.Models.ADUser", "ADUsers")
                        .WithMany("Dismissals")
                        .HasForeignKey("NrSap");
                });

            modelBuilder.Entity("SZZP2._2.Models.Employment", b =>
                {
                    b.HasOne("SZZP2._2.Models.Office", "Offices")
                        .WithMany("Employment")
                        .HasForeignKey("IDOffice")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SZZP2._2.Models.Position", "Positions")
                        .WithMany()
                        .HasForeignKey("IDPosition")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SZZP2._2.Models.Status", "Statuses")
                        .WithMany()
                        .HasForeignKey("IDStatus")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
