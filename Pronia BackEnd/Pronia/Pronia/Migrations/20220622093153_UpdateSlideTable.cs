using Microsoft.EntityFrameworkCore.Migrations;

namespace Pronia.Migrations
{
    public partial class UpdateSlideTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Context",
                table: "Slides",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Precent",
                table: "Slides",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Slides",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Context",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "Precent",
                table: "Slides");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Slides");
        }
    }
}
