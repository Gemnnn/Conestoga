using Microsoft.EntityFrameworkCore.Migrations;

namespace PROG2230_Byounguk_Min.Migrations
{
    public partial class Company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "TransactionRecords");

            migrationBuilder.DropColumn(
                name: "TickerSymbol",
                table: "TransactionRecords");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "TransactionRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyModels",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ticker = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyModels", x => x.CompanyId);
                });

            migrationBuilder.InsertData(
                table: "CompanyModels",
                columns: new[] { "CompanyId", "CompanyAddress", "CompanyName", "Ticker" },
                values: new object[] { 1, "453 bill Gates Drive", "Micorsoft", "MSFT" });

            migrationBuilder.InsertData(
                table: "CompanyModels",
                columns: new[] { "CompanyId", "CompanyAddress", "CompanyName", "Ticker" },
                values: new object[] { 2, "123 Google Way", "Google", "GOOG" });

            migrationBuilder.InsertData(
                table: "CompanyModels",
                columns: new[] { "CompanyId", "CompanyAddress", "CompanyName", "Ticker" },
                values: new object[] { 3, "234 Walmart Street", "Walmart", "WMT" });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 1,
                column: "CompanyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 2,
                column: "CompanyId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 3,
                column: "CompanyId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecords_CompanyId",
                table: "TransactionRecords",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRecords_CompanyModels_CompanyId",
                table: "TransactionRecords",
                column: "CompanyId",
                principalTable: "CompanyModels",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRecords_CompanyModels_CompanyId",
                table: "TransactionRecords");

            migrationBuilder.DropTable(
                name: "CompanyModels");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRecords_CompanyId",
                table: "TransactionRecords");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "TransactionRecords");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "TransactionRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TickerSymbol",
                table: "TransactionRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 1,
                columns: new[] { "CompanyName", "TickerSymbol" },
                values: new object[] { "Microsoft", "MSFT" });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 2,
                columns: new[] { "CompanyName", "TickerSymbol" },
                values: new object[] { "Google", "GOOG" });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 3,
                columns: new[] { "CompanyName", "TickerSymbol" },
                values: new object[] { "Walmart", "WMT" });
        }
    }
}
