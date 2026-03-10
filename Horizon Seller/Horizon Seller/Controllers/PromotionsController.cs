using Microsoft.AspNetCore.Mvc;
using Horizon_Seller.Models;

namespace Horizon_Seller.Controllers
{
    public class PromotionsController : Controller
    {
        public IActionResult Promotion()
        {
            return View();
        }

        // This handles BOTH Add and Edit!
        [HttpGet]
        public IActionResult AddPromotion(int? id)
        {
            if (id.HasValue && id > 0)
            {
                // EDIT MODE: 
                // 1. Fetch the promotion from your database using the 'id'
                // 2. Map the database item to a new PromotionViewModel
                // (This is mock data just to show you how it works)
                var editModel = new PromotionViewModel
                {
                    Id = id.Value,
                    Name = "Sample Summer Sale",
                    Type = "Fix Amount", // My JS will automatically open the Fix Amount tab because of this!
                    TotalDiscountFix = 500,
                    Status = "Active"
                };

                return View(editModel); // Sends the data to the view
            }

            // ADD MODE: Just send an empty model
            return View(new PromotionViewModel());
        }

        [HttpPost]
        public IActionResult AddPromotion(PromotionViewModel model)
        {
            // Here is where you save the new OR edited promotion to your database
            if (model.Id > 0)
            {
                // Update existing
            }
            else
            {
                // Create new
            }

            return RedirectToAction("Index"); // Redirect back to list
        }
    }
}
