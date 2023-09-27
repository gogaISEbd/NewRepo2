using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class Hostel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Condit",
                table: "MainOperations",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Payed",
                table: "MainOperations",
                type: "numeric",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condit",
                table: "MainOperations");

            migrationBuilder.DropColumn(
                name: "Payed",
                table: "MainOperations");
        }
    }
}
