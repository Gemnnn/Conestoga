using Microsoft.EntityFrameworkCore.Migrations;

namespace PROG2230_AS1_BMin.Migrations
{
    public partial class TransactionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionTypeId",
                table: "TransactionRecords",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    TransactionTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commission = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.TransactionTypeId);
                });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "Commission", "Name" },
                values: new object[,] 
                {
                    { "B", 5.99, "Buy" },
                    { "S", 5.40, "Sell" }
                });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 1,
                columns: new[] { "CompanyName", "SharePrice", "TickerSymbol", "TransactionTypeId" },
                values: new object[] { "Microsoft", 123.45, "MSFT", "B" });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 2,
                columns: new[] { "CompanyName", "SharePrice", "TickerSymbol", "TransactionTypeId" },
                values: new object[] { "Google", 2701.7600000000002, "GOOG", "S" });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 3,
                column: "TransactionTypeId",
                value: "B");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRecords_TransactionTypeId",
                table: "TransactionRecords",
                column: "TransactionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRecords_TransactionTypes_TransactionTypeId",
                table: "TransactionRecords",
                column: "TransactionTypeId",
                principalTable: "TransactionTypes",
                principalColumn: "TransactionTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRecords_TransactionTypes_TransactionTypeId",
                table: "TransactionRecords");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRecords_TransactionTypeId",
                table: "TransactionRecords");

            migrationBuilder.DropColumn(
                name: "TransactionTypeId",
                table: "TransactionRecords");

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 1,
                columns: new[] { "CompanyName", "SharePrice", "TickerSymbol" },
                values: new object[] { "Google", 2701.7600000000002, "GOOG" });

            migrationBuilder.UpdateData(
                table: "TransactionRecords",
                keyColumn: "TransactionRecordId",
                keyValue: 2,
                columns: new[] { "CompanyName", "SharePrice", "TickerSymbol" },
                values: new object[] { "Microsoft", 123.45, "MSFT" });
        }
    }
}
