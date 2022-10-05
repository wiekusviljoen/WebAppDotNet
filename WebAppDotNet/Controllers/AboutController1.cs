using Microsoft.AspNetCore.Mvc;

namespace WebAppDotNet.Controllers
{
    public class AboutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
