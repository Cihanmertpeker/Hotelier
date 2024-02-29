using Microsoft.AspNetCore.Mvc;

namespace Hotelier.WebUI.Controllers
{
    public class AdminAboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
