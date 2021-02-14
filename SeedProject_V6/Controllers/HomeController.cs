using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeedProject_V6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeedProject_V6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Index() {
            return View();
        }

        [HttpGet]
        public ActionResult Introduction() {
            return View();
        }

        [HttpGet]
        public ActionResult SchoolProgram()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return Redirect("https://seed.moodlecloud.com/login/index.php");
        }

        [HttpGet]
        public ActionResult Esl()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AcademicBoost()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestPrep()
        {
            return View();
        }

    }
}
