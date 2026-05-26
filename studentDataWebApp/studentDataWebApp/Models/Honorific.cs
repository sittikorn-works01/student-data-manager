using System.ComponentModel.DataAnnotations;

namespace studentDataWebApp.Models
{
    public enum Honorific
    {
        [Display(Name = "นาย")] นาย,
        [Display(Name = "นาง")] นาง,
        [Display(Name = "นางสาว")] นางสาว,
        //[Display(Name = "เด็กชาย")] เด็กชาย,
        //[Display(Name = "เด็กหญิง")] เด็กหญิง
    }
}
