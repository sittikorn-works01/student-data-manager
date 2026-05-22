using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace studentDataWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนรหัสนักศึกษา")]
        [DisplayName("รหัสนักศึกษา")]
        public string StudentId { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนคำนำหน้านาม")]
        [DisplayName("คำนำหน้านาม")]
        public string Honorifics { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนชื่อ")]
        [DisplayName("ชื่อ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนนามสกุล")]
        [DisplayName("นามสกุล")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนวันเดือนปีเกิด")]
        [DisplayName("วันเดือนปีเกิด")]
        public DateOnly? DateOfBirth { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนสำนักวิชา")]
        [DisplayName("สำนักวิชา")]
        //public string Faculty { get; set; }
        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
    }
}   