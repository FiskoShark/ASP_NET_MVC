using Microsoft.AspNetCore.Mvc;
using ShipmentApp.Models;

namespace ShipmentApp.Controllers
{
    public class ShipmentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShipmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View("Details", model);
        }
    }
}

