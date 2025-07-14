using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
