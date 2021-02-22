using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeedProject_V6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeedProject_V6.Controllers
{
    public class ProductController : Controller
    {
        Seed_DBContext context = new Seed_DBContext();

        IEnumerable<SeedProduct> products { get; set; }

        [HttpGet]
        public async Task<IActionResult> AllProductsAsync()
        {
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
                    var readContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(readContent);


                    List<SeedProduct> productResult = JsonConvert.DeserializeObject<List<SeedProduct>>(readContent);

                    products = productResult;
                }
                else //web api sent error response 
                {
                    //log response status here..
                    Console.WriteLine("DROOOOOP");
                    products = Enumerable.Empty<SeedProduct>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(products);
        }

        [HttpGet]
        public RedirectResult goToCart(int ProductID) {
            return Redirect("https://rainforest.azurewebsites.net/Product/ViewProduct?productId="+ProductID);
        }
    }
}
