using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using StudentGradingSystemData.Models;
using StudentGradingSystemData.Repositories;
using System.Data;
using System.Diagnostics;

namespace StudentGradingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}