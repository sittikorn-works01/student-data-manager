using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentDataWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddHonorificEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
