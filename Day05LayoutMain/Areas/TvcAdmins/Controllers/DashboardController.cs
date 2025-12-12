using Microsoft.AspNetCore.Mvc;

namespace Day05LayoutMain.Areas.TvcAdmins.Controllers
{
    [Area("TvcAdmins")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
