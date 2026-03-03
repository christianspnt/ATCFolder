using Microsoft.AspNetCore.Mvc;

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
    }

}

