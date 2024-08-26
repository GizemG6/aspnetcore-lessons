using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var course = new Course();
            course.Id = 1;
            course.Title = "Aspnet core kursu";
            course.Description = "Güzel bir kurs";
            return View(course);
        }

        public IActionResult List()
        {
            var courses = new List<Course>
            {
                new Course() { Id = 1, Title = "aspnet kursu", Description = "güzel bir kurs", Image = "1.jpg"},
                new Course() { Id = 2, Title = "php kursu", Description = "güzel bir kurs", Image = "2.jpg"},
                new Course() { Id = 2, Title = "react kursu", Description = "güzel bir kurs", Image = "3.jpg"}
            };
            return View("CourseList", courses);
        }
    }
}