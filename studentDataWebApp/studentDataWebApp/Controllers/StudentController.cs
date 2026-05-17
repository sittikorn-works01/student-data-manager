using Microsoft.AspNetCore.Mvc;

namespace studentDataWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
