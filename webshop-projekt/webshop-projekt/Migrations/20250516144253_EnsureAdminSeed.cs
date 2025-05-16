using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webshop_projekt.Migrations
{
    /// <inheritdoc />
    public partial class EnsureAdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb8fc72-f075-4957-907d-4fb7dfbc3dc2", "AQAAAAIAAYagAAAAEGwg6cSVl8oVVV824rn34orpw3HEtuj4CNJJwmfYG/orancSCE7a6s4uu/r4CLSFIQ==", "0e377628-269a-4963-8751-43d8be4305ea" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d195f440-d034-43d0-8a7a-aa0dfc0b9e46", "AQAAAAIAAYagAAAAELXgUm+fJSKnAV45OjcYaix4uTXH8aMXjBvlC4f19X5CeqUG4F1PzzynZybv/moQQg==", "45343e7a-d4ef-4c4d-96bb-63febdd98577" });
        }
    }
}
