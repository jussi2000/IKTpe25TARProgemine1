using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;
using University.Models;
using University.ViewModel.CoursesVM;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        private readonly UniversityContext _context;

        public CourseController
            (
                UniversityContext context
            )
        {
            _context = context;
        }
        //on vaja kutsuda välja University constructror 
        public async Task<IActionResult> Index()
        {
            var course = _context.Courses
                .Select(c => new CourseIndexViewModel
                {
                    CourseId = c.CourseId,
                    Credits = c.Credits,
                    Title = c.Title,
                    DepartmentId = c.DepartmentId,
                    Department = new CourseDepartmentIndexViewModel
                    {
                        DepartmentName = c.Departments.Name
                    }
                });

            return View(course);
        }
    }
}
