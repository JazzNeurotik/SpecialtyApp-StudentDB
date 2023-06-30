using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpecialtyApp.Models;

namespace SpecialtyApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly SpecialtyContext _context;
        public StudentController(SpecialtyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string grade)
        {
            var students = _context.Students.Where(s => s.Grade == grade).ToList();
            return View(students);
        }
    }
}