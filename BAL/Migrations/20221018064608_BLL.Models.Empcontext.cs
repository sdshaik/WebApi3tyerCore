using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLL.Migrations
{
    public partial class BLLModelsEmpcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empgender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpDob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpDep = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmpId", "EmpDep", "EmpDob", "EmpEmail", "EmpName", "Empgender" },
                values: new object[] { 1, "Devloper", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jhon@gmail.com", "Jhon", "Male" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
