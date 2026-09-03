using Microsoft.AspNetCore.Mvc;

namespace SearchPortal.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(string query)
        {
            ViewBag.Query = query;

            return View();
        }
    }
}
