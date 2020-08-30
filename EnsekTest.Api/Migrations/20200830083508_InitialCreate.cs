using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnsekTest.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeterReadings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeterReadingDateTime = table.Column<DateTime>(nullable: false),
                    MeterReadValue = table.Column<string>(maxLength: 5, nullable: false),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterReadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterReadings_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2344, "Tommy", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1246, "Jo", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1245, "Neville", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1244, "Tony", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1243, "Graham", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1242, "Tim", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1241, "Lara", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1240, "Archie", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1239, "Noddy", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1234, "Freya", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 4534, "JOSH", "TEST" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 6776, "Laura", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1247, "Jim", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2356, "Craig", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2353, "Tony", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2352, "Greg", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2351, "Gladys", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2350, "Colin", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2349, "Simon", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2348, "Tammy", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2347, "Tara", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2346, "Ollie", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2345, "Jerry", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 8766, "Sally", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2233, "Barry", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2355, "Arthur", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1248, "Pam", "Test" });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 1, 2344, "01002", new DateTime(2019, 4, 22, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 25, 1246, "03455", new DateTime(2019, 5, 25, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 24, 1245, "00676", new DateTime(2019, 5, 25, 14, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 23, 1244, "03478", new DateTime(2019, 5, 25, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 22, 1243, "00077", new DateTime(2019, 5, 21, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 21, 1242, "00124", new DateTime(2019, 5, 20, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 20, 1241, "00436", new DateTime(2019, 4, 11, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 19, 1240, "00978", new DateTime(2019, 5, 18, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 18, 1239, "45345", new DateTime(2019, 5, 17, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 17, 1234, "09787", new DateTime(2019, 5, 12, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 16, 6776, "23566", new DateTime(2019, 5, 10, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 15, 6776, "-6575", new DateTime(2019, 5, 9, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 26, 1247, "00003", new DateTime(2019, 5, 25, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 14, 2356, "00000", new DateTime(2019, 5, 7, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 12, 2353, "01212", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 11, 2352, "00455", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 10, 2351, "57579", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 9, 2350, "05684", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 8, 2348, "00123", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 7, 2347, "00054", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 6, 2346, "999999", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 5, 2345, "45522", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 3, 8766, "03440", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 2, 2233, "00323", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 4, 2344, "01002", new DateTime(2019, 4, 22, 12, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 13, 2355, "00001", new DateTime(2019, 5, 6, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "MeterReadings",
                columns: new[] { "Id", "AccountId", "MeterReadValue", "MeterReadingDateTime" },
                values: new object[] { 27, 1248, "03467", new DateTime(2019, 5, 26, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_MeterReadings_AccountId",
                table: "MeterReadings",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeterReadings");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
