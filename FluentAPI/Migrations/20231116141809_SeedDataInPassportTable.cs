using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FluentAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInPassportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSalon_Cars_CarId",
                table: "CarSalon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarSalon",
                table: "CarSalon");

            migrationBuilder.DropIndex(
                name: "IX_CarSalon_CarId",
                table: "CarSalon");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CarSalon",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarSalon",
                table: "CarSalon",
                columns: new[] { "CarId", "SalonId" });

            migrationBuilder.InsertData(
                table: "Passports",
                columns: new[] { "Id", "Address", "Lastname", "Middlename", "Name", "Nation" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Doe", "M", "John", "USA" },
                    { 2, "456 Oak St", "Doe", "N", "Jane", "Canada" },
                    { 3, "789 Elm St", "Smith", "A", "Alice", "UK" },
                    { 4, "101 Pine St", "Johnson", "B", "Bob", "Australia" },
                    { 5, "202 Maple St", "Williams", "E", "Eva", "Germany" },
                    { 6, "303 Birch St", "Brown", "C", "Charlie", "France" },
                    { 7, "404 Cedar St", "Jones", "G", "Grace", "Spain" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CarSalon_Cars_CarId",
                table: "CarSalon",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarSalon_Cars_CarId",
                table: "CarSalon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarSalon",
                table: "CarSalon");

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Passports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CarSalon",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarSalon",
                table: "CarSalon",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CarSalon_CarId",
                table: "CarSalon",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarSalon_Cars_CarId",
                table: "CarSalon",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
