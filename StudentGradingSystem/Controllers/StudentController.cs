using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentGradingSystemData.Models;
using StudentGradingSystemData.Repositories;
using StudentGradingSystemData.Services;

namespace StudentGradingSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IGradeCalculator _gradeCalculator;

        public StudentController(IConfiguration config)
        {
            _studentRepository = new StudentRepository(config);
            _gradeCalculator = new GradeCalculator();
        }

        // GET: StudentController
        public async Task<IActionResult> Index()
        {
            var response = await _studentRepository.GetAll();

            return View(response);
        }

        public async Task<IActionResult> ViewGrades(int id)
        {
            var response = await _studentRepository.GetGrades(id);

            List<GradeModel> grades = new List<GradeModel>();

            foreach (var grade in response)
            {
                grades.Add(new GradeModel { Subject = grade.Subject, Score = grade.Score, });
            }

            ViewData["Average"] = _gradeCalculator.CalculateGradeAverage(grades);

            return View(response);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
