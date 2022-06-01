using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciaLeads.Api.Migrations
{
    public partial class PopulaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Accepted", "Category", "DateCreated", "Description", "EmailAddress", "FullName", "PhoneNumber", "Price", "Suburb" },
                values: new object[,]
                {
                    { 5121931, "Y", "Home Renovations", new DateTime(2022, 5, 31, 22, 52, 1, 27, DateTimeKind.Local).AddTicks(6304), "There is a two ...", "another.fake@hipmail.com", "Craig Test", "04987654321", 32, "Quinns Rock 6030" },
                    { 5141895, "Y", "General Building Work", new DateTime(2022, 5, 31, 22, 52, 1, 27, DateTimeKind.Local).AddTicks(6303), "Plaster exposed...", "fake@mailinator.com", "Pete", "0412345678", 26, "Carramar 6031" },
                    { 5577421, "N", "Painters", new DateTime(2022, 5, 31, 22, 52, 1, 27, DateTimeKind.Local).AddTicks(6285), "Need to paint 2 aluminum windows and a sliding glass door", "bill@test.com", "Bill Test", "1198765423456", 62, "Yanderra 2574" },
                    { 5588872, "N", "Interior Painters", new DateTime(2022, 5, 31, 22, 52, 1, 27, DateTimeKind.Local).AddTicks(6301), "internal walls 3 colours", "craig@test.com", "Craig Test", "1198765423451", 49, "Woolooware 2230" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 5121931);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 5141895);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 5577421);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 5588872);
        }
    }
}
