using Microsoft.AspNetCore.Mvc;

namespace QazaqTili.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
