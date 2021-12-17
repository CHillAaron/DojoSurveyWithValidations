using DojoSurveyWithValidations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DojoSurveyWithValidations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Result")]
        public IActionResult Result(Dojo student)
        {
            if (ModelState.IsValid)
            {
                return View(student);
            }
            else
            {
                return View("Index");
            }
        }

    }
}
