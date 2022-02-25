using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuarterlySales.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    DateOfHire = table.Column<DateTime>(nullable: false),
                    ManagerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SalesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quarter = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SalesId);
                    table.ForeignKey(
                        name: "FK_Sales_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DateOfHire", "Firstname", "Lastname", "ManagerId" },
                values: new object[,]
                {
                    { 1, new DateTime(1956, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ada", "Lovelace", 0 },
                    { 2, new DateTime(1966, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katherine", "Johnson", 1 },
                    { 3, new DateTime(1975, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", "Hopper", 1 },
                    { 4, new DateTime(1960, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Homer", "Simpson", 0 },
                    { 5, new DateTime(1980, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart", "Simpson", 4 },
                    { 6, new DateTime(1962, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marge", "Simpson", 0 },
                    { 7, new DateTime(1982, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", "Simpson", 6 },
                    { 8, new DateTime(2005, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maggie", "Simpson", 6 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SalesId", "Amount", "EmployeeId", "Quarter", "Year" },
                values: new object[,]
                {
                    { 1, 23456.0, 2, 4, 2019 },
                    { 2, 34567.0, 2, 1, 2020 },
                    { 3, 19876.0, 3, 4, 2019 },
                    { 4, 31009.0, 3, 1, 2020 },
                    { 12, 21009.0, 3, 1, 2020 },
                    { 5, 33476.0, 4, 3, 2019 },
                    { 11, 29876.0, 4, 4, 2019 },
                    { 6, 24555.0, 5, 2, 2020 },
                    { 10, 14567.0, 5, 3, 2020 },
                    { 7, 29123.0, 6, 3, 2019 },
                    { 9, 33456.0, 6, 2, 2019 },
                    { 8, 21111.0, 7, 4, 2020 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
