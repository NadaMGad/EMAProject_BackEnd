using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMA_Project.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
