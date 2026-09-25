using Atrebuti_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atrebuti_.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel2 user)
        {
            if (ModelState.IsValid)//з атребутами//
            {
                return View("Confirmation", user);
            }

            return View(user);
        }
    }
}