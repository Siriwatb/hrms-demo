﻿// <auto-generated />
using System;
using HRMS.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRMS.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(EmployeesDbContext))]
    [Migration("20241112173622_SeedEmployeeData")]
    partial class SeedEmployeeData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRMS.Domain.Entities.Employee", b =>
                {
                    b.Property<string>("EmpNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Comm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DeptNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmpNo");

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            EmpNo = "1001",
                            Comm = 0m,
                            DeptNo = "40",
                            Designation = "BUSINESS ANALYST",
                            FirstName = "STEFAN",
                            HireDate = new DateTime(1997, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "SALVATORE",
                            Salary = 50000m
                        },
                        new
                        {
                            EmpNo = "1002",
                            Comm = 0m,
                            DeptNo = "10",
                            Designation = "TECHNICAL ARCHITECT",
                            FirstName = "DIANA",
                            HireDate = new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "LORRENCE",
                            Salary = 70000m
                        },
                        new
                        {
                            EmpNo = "1003",
                            Comm = 0m,
                            DeptNo = "40",
                            Designation = "MANAGER",
                            FirstName = "JAMES",
                            HireDate = new DateTime(1988, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "MADISON",
                            Salary = 80400m
                        },
                        new
                        {
                            EmpNo = "1005",
                            Comm = 200m,
                            DeptNo = "30",
                            Designation = "HR ASSOCIATE",
                            FirstName = "LUCY",
                            HireDate = new DateTime(2008, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "GELLER",
                            Salary = 35000m
                        },
                        new
                        {
                            EmpNo = "1006",
                            Comm = 0m,
                            DeptNo = "40",
                            Designation = "TRAINEE",
                            FirstName = "ISAAC",
                            HireDate = new DateTime(2015, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "STEFAN",
                            Salary = 20000m
                        },
                        new
                        {
                            EmpNo = "1007",
                            Comm = 0m,
                            DeptNo = "10",
                            Designation = "CLERK",
                            FirstName = "JOHN",
                            HireDate = new DateTime(2005, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "SMITH",
                            Salary = 12000m
                        },
                        new
                        {
                            EmpNo = "1008",
                            Comm = 300m,
                            DeptNo = "10",
                            Designation = "SALESMAN",
                            FirstName = "NANCY",
                            HireDate = new DateTime(1981, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "GILBERT",
                            Salary = 1600m
                        },
                        new
                        {
                            EmpNo = "1004",
                            Comm = 0m,
                            DeptNo = "30",
                            Designation = "HR ANALYST",
                            FirstName = "JONES",
                            HireDate = new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "NICK",
                            Salary = 47000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
