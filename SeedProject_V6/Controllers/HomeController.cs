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

    }
}
