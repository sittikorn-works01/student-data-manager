using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace studentDataWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("รหัสนักศึกษา")]
        public string StudentId { get; set; }
        [Required]
        [DisplayName("คำนำหน้า")]
        public string Honorifics { get; set; }
        [Required]
        [DisplayName("ชื่อ")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("นามสกุล")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("วันเดือนปีเกิด")]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        [DisplayName("สำนักวิชา")]
        public string Faculty { get; set; }
    }
}   