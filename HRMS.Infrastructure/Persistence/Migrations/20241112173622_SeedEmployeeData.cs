using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRMS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpNo", "Comm", "DeptNo", "Designation", "FirstName", "HireDate", "LastName", "Salary" },
                values: new object[,]
                {
                    { "1001", 0m, "40", "BUSINESS ANALYST", "STEFAN", new DateTime(1997, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SALVATORE", 50000m },
                    { "1002", 0m, "10", "TECHNICAL ARCHITECT", "DIANA", new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LORRENCE", 70000m },
                    { "1003", 0m, "40", "MANAGER", "JAMES", new DateTime(1988, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "MADISON", 80400m },
                    { "1004", 0m, "30", "HR ANALYST", "JONES", new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "NICK", 47000m },
                    { "1005", 200m, "30", "HR ASSOCIATE", "LUCY", new DateTime(2008, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "GELLER", 35000m },
                    { "1006", 0m, "40", "TRAINEE", "ISAAC", new DateTime(2015, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "STEFAN", 20000m },
                    { "1007", 0m, "10", "CLERK", "JOHN", new DateTime(2005, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SMITH", 12000m },
                    { "1008", 300m, "10", "SALESMAN", "NANCY", new DateTime(1981, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "GILBERT", 1600m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1001");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1002");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1003");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1004");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1005");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1006");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1007");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmpNo",
                keyValue: "1008");
        }
    }
}
