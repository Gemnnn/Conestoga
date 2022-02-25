using Microsoft.EntityFrameworkCore.Migrations;

namespace PROG2230_Byounguk_Min.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionRecords",
                columns: table => new
                {
                    TransactionRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TickerSymbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SharePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRecords", x => x.TransactionRecordId);
                });

            migrationBuilder.InsertData(
                table: "TransactionRecords",
                columns: new[] { "TransactionRecordId", "CompanyName", "Quantity", "SharePrice", "TickerSymbol" },
                values: new object[] { 1, "Microsoft", 100, 123.45, "MSFT" });

            migrationBuilder.InsertData(
                table: "TransactionRecords",
                columns: new[] { "TransactionRecordId", "CompanyName", "Quantity", "SharePrice", "TickerSymbol" },
                values: new object[] { 2, "Google", 100, 2701.7600000000002, "GOOG" });

            migrationBuilder.InsertData(
                table: "TransactionRecords",
                columns: new[] { "TransactionRecordId", "CompanyName", "Quantity", "SharePrice", "TickerSymbol" },
                values: new object[] { 3, "Walmart", 200, 140.97999999999999, "WMT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionRecords");
        }
    }
}
