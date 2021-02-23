using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SeedProject_V6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
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
        public ActionResult Tap()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestPrep()
        {
            return View(FindProductsByName("Math", "Science"));
        }

        [HttpGet]
        public ActionResult MathScience()
        {
            return View(FindProductsByName("Math","Science"));
        }

        [HttpGet]
        public ActionResult SeedCredit()
        {
            return View(FindProductsByName("Math", "Science"));
        }

        [HttpGet]
        public ActionResult EnglishLearning()
        {
            return View(FindProductsByName("ESL","IELTS"));
        }

        public List<SeedProduct> FindProductsByName(string string1, string string2 = "0")
        {
            List<SeedProduct> products = new List<SeedProduct>();

            using (var client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get,
            "https://rainforest.azurewebsites.net/api/VendorProduct/GetVendorProducts/37");
                //HTTP GET
                var responseTask = client.SendAsync(request);
                responseTask.Wait();

                var response = responseTask.Result;

                if (response.IsSuccessStatusCode)
                {
                    var readContent = response.Content.ReadAsStringAsync();
                    readContent.Wait();
                    Console.WriteLine(readContent);


                    List<SeedProduct> productResult = JsonConvert.DeserializeObject<List<SeedProduct>>(readContent.Result);
                    for (int i = 0; i < productResult.Count; i++)
                    {
                        if (productResult[i].ProductName.Contains(string1) || productResult[i].ProductName.Contains(string2))
                        {
                            products.Add(productResult[i]);
                        }
                    }
                }
                else //web api sent error response 
                {
                    //log response status here..
                    Console.WriteLine("DROOOOOP");
                    products = Array.Empty<SeedProduct>().ToList();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return products;
        }


        [HttpGet]
        public RedirectResult goToCart(int ProductID)
        {
            return Redirect("https://rainforest.azurewebsites.net/Product/ViewProduct?productId=" + ProductID);
        }

    }
}
