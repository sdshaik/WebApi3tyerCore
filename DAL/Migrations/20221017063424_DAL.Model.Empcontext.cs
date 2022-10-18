using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class DALModelEmpcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
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
                    table.PrimaryKey("PK_Employees", x => x.EmpId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpId", "EmpDep", "EmpDob", "EmpEmail", "EmpName", "Empgender" },
                values: new object[] { 1, "Devloper", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jhon@gmail.com", "Jhon", "Male" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
