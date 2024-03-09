using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCApp1.Migrations
{
    /// <inheritdoc />
    public partial class Raiting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Raiting",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Raiting",
                table: "Movie");
        }
    }
}
