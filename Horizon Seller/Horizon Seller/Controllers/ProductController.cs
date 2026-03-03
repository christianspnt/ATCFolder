using Horizon_Seller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Horizon_Seller.Controllers // Note: Your actual namespace might be slightly different
{
    public class ProductController : Controller
    {
        // This is likely your existing Create action
        public IActionResult Create()
        {
            return View();
        }

        // ADD THIS NEW ACTION for your View Product page
        public IActionResult ViewProduct()
        {
            return View();
        }

        // For Size Guide action
        public IActionResult sizeguide()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewSizeGuide(int id)
        {
            // Dummy data to make the table render so you can see your design
            var model = new ViewSizeGuideViewModel
            {
                ProductId = id,
                ProductTitle = "Nike Women's tops (Asian sizing)",
                IsPhotoUpload = false, // Set to true if you want to test the photo gallery instead
                MeasurementUnit = "in",
                Category = "Tops",
                TableTitle = "Nike Size Charts",
                FitTips = "If you're on the borderline between two sizes, order the smaller size for a tighter fit or the larger size for a looser fit.",
                HowToMeasure = "Chest: Measure around the fullest part of your chest, keeping the measuring tape horizontal.",
                TableData = new List<List<string>>
                {
                    new List<string> { "Size", "XXS", "XS", "S", "M", "L", "XL", "XXL" },
                    new List<string> { "Bust (in.)", "28.5 - 30", "30 - 32", "32 - 33.5", "33.5 - 35", "35 - 37.5", "37.5 - 40", "40 - 42.5" },
                    new List<string> { "Waist (in.)", "24.5 - 26", "26 - 27", "27 - 28", "28 - 29.5", "29.5 - 31.5", "31.5 - 33.5", "33.5 - 35.5" },
                    new List<string> { "Hip (in.)", "33 - 34", "34 - 35", "35 - 36.5", "36.5 - 38", "38 - 40", "40 - 42", "42 - 44" }
                }
            };

            return View(model);
        }

    }

}

