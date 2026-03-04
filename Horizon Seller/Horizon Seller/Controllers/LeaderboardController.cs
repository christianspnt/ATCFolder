using Microsoft.AspNetCore.Mvc;

namespace Horizon_Seller.Controllers
{
    public class LeaderboardController : Controller
    {
        public IActionResult LeaderboardDashboard()
        {
            return View();
        }
    }
}
