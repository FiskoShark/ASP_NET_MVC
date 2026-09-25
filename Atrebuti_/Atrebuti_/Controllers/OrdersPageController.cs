using Atrebuti_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atrebuti_.Controllers
{
    public class OrdersPageController : Controller
    {
        // ============================================ //
        // GET /OrdersPage/Create     // Показує форму //
        // ========================================== //
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //// ================================================= //
        //// POST /OrdersPage/Create  // Отримує дані з форми //
        //// =============================================== //
        //[HttpPost]
        //public IActionResult Create(OrderModel order)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(order);
        //    }

        //    return View("Create", order);
        //}
    }
}