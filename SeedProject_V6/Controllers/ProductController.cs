using Microsoft.AspNetCore.Mvc;
using SeedProject_V6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedProject_V6.Controllers
{
    public class ProductController : Controller
    {
        Seed_DBContext context = new Seed_DBContext();
        public IActionResult AllProducts()
        {
            List<SeedProduct> products = context.SeedProducts.ToList();   
            return View(products);
        }
    }
}
