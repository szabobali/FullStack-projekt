using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webshop_projekt.Migrations
{
    /// <inheritdoc />
    public partial class Namehozzaadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Goods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Goods");
        }
    }
}
