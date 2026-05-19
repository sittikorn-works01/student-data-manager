using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using studentDataWebApp.Data;
using studentDataWebApp.Models;

namespace studentDataWebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StudentController(ApplicationDBContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> allStudent = _db.Students;
            return View(allStudent);
        }

        public IActionResult Create()
        {
            return View();
        }   

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(newStudent);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newStudent);            
        }

        public IActionResult Edit(int? id) {
            if (id == null || id == 0) return NotFound();
            
            var obj = _db.Students.Find(id);
            if (obj == null) return NotFound();
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student editedStudent)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(editedStudent);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(editedStudent);
        }
    }
}
