using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentDataWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFacultyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyId",
                table: "Students",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Faculties_FacultyId",
                table: "Students",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Faculties_FacultyId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropIndex(
                name: "IX_Students_FacultyId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
