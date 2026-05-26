using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace studentDataWebApp.Models
{
    public class Student
    {
        public enum Honorific
        {
            [Display(Name = "นาย")] นาย,
            [Display(Name = "นาง")] นาง,
            [Display(Name = "นางสาว")] นางสาว,
            [Display(Name = "เด็กชาย")] เด็กชาย,
            [Display(Name = "เด็กหญิง")] เด็กหญิง
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนรหัสนักศึกษา")]
        [DisplayName("รหัสนักศึกษา")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนคำนำหน้านาม")]
        [DisplayName("คำนำหน้านาม")]
        public Honorific Title { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อ")]
        [RegularExpression(@"^[a-zA-Zก-ฮะ-์\s]+$", ErrorMessage = "ชื่อต้องเป็นตัวอักษรเท่านั้น (ห้ามใส่ตัวเลข)")]
        [DisplayName("ชื่อ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนนามสกุล")]
        [RegularExpression(@"^[a-zA-Zก-ฮะ-์\s]+$", ErrorMessage = "สกุลต้องเป็นตัวอักษรเท่านั้น (ห้ามใส่ตัวเลข)")]
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