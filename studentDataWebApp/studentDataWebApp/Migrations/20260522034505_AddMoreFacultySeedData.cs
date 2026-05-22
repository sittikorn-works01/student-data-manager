using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentDataWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreFacultySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1,
                column: "FacultyName",
                value: "สำนักวิชาแพทยศาสตร์");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2,
                column: "FacultyName",
                value: "สำนักวิชาวิศวกรรมศาสตร์และเทคโนโลยี");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3,
                column: "FacultyName",
                value: "สำนักวิชาสารสนเทศศาสตร์");

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "FacultyName" },
                values: new object[] { 4, "สำนักวิชาศึกษาศาสตร์" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1,
                column: "FacultyName",
                value: "สำนักวิชาวิทยาศาสตร์");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2,
                column: "FacultyName",
                value: "สำนักวิชาวิศวกรรมศาสตร์");

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3,
                column: "FacultyName",
                value: "สำนักวิชาเทคโนโลยีสารสนเทศ");
        }
    }
}
