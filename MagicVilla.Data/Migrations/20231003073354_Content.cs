using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.Data.Migrations
{
    public partial class Content : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreateAt", "Details", "FirstName", "ImageUrl", "LastName", "Occupancy", "Rate", "Sqft", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Amw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great", "John", "Beauitiful", "James", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Amw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excelent", "Paul", "Beauitiful", "Philip", 4, 300.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Amw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elijah", "Peter", "Beauitiful", "Wisdom", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Amw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chika", "Emma", "Florence", "Sam", 4, 300.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Amw", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ebube", "Joy", "Faith", "Miracle", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
