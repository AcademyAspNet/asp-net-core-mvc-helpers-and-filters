using AspNetCoreMvcHelpers.Filters;
using AspNetCoreMvcHelpers.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcHelpers.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        [ServiceFilter(typeof(LogActionFilter))]
        public IActionResult Index()
        {
            return View(new FormViewModel());
        }

        [HttpPost]
        public IActionResult Process([FromForm] FormViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Index");

            return View("Result", model);
        }
    }
}
