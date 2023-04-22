using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class UpRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Rooms",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rooms",
                table: "Rooms",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Size",
                table: "Rooms",
                type: "numeric",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Rooms",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Rooms");
        }
    }
}
