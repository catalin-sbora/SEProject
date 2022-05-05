using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEProjectApp.Abstractions.Repository;
using SEProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SEProjectApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentsRepository studentsRepository;
        public HomeController(ILogger<HomeController> logger, IStudentsRepository studentsRepository)
        {
            _logger = logger;
            this.studentsRepository = studentsRepository;
        }

        public IActionResult Index()
        {
            var students = studentsRepository.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
