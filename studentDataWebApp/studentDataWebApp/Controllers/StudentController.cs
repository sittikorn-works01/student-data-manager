using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        //public IActionResult Index()
        //{
        //    IEnumerable<Student> allStudent = _db.Students;
        //    return View(allStudent);
        //}
        public IActionResult Create()
        {
            ViewBag.FacultyId = new SelectList(_db.Faculties, "Id", "FacultyName");
            return View();
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}

        public IActionResult Index(string searchString)
        {
            var students = _db.Students.Include(s => s.Faculty).AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.StudentId.Contains(searchString)
                                            || s.FirstName.Contains(searchString)
                                            || s.LastName.Contains(searchString));
            }

            ViewData["CurrentFilter"] = searchString;
            return View(students.ToList());
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
            ViewBag.FacultyId = new SelectList(_db.Faculties, "Id", "FacultyName");
            return View(newStudent);            
        }

        public IActionResult Edit(int? id) {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            ViewBag.FacultyId = new SelectList(_db.Faculties, "Id", "FacultyName");
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
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

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) {
                return NotFound();
            } 

            var obj = _db.Students.Find(id);
            if (obj == null) {
                return NotFound();
            } 
            _db.Students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
