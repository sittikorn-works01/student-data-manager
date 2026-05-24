using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace studentDataWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialFaculties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "FacultyName" },
                values: new object[,]
                {
                    { 1, "สำนักวิชาวิทยาศาสตร์" },
                    { 2, "สำนักวิชาวิศวกรรมศาสตร์" },
                    { 3, "สำนักวิชาเทคโนโลยีสารสนเทศ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
