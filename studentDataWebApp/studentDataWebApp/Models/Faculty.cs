using System.ComponentModel.DataAnnotations;

namespace studentDataWebApp.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "สำนักวิชา")]
        public string FacultyName { get; set; }
    }
}
