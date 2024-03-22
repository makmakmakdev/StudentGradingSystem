using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentGradingSystemData.Models;
using StudentGradingSystemData.Repositories;

namespace StudentGradingSystem.Controllers
{
    public class GradeController : Controller
    {
        private readonly IGradeRepository _gradeRepository;

        public GradeController(IConfiguration config)
        {
            _gradeRepository = new GradeRepository(config);
        }

        // GET: GradeController
        public async Task<IActionResult> Index()
        {
            var response = await _gradeRepository.GetAll();

            return View(response);
        }

        // GET: GradeController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GradeController/Create
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] GradeModel grade)
        {
            try
            {
                await _gradeRepository.Add(grade);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
