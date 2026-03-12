using Microsoft.AspNetCore.Mvc;

namespace Horizon_Seller.Controllers
{
    public class LeaderboardController : Controller
    {
        public IActionResult LeaderboardDashboard()
        {
            return View();
        }

        public IActionResult viewallboard()
        {
            return View();
        }

        public IActionResult leaderboard()
        {
            return View();
        }
    }
}
