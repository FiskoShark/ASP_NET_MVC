using AnimalApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalApp.Controllers{
    public class AnimalController : Controller
    {
        private readonly List<Animal> animals =
        [
            new Animal { Id = 1, Name = "Мурчик", Species = "Кіт", Age = 3, Color = "Рудий" },
    new Animal { Id = 2, Name = "Рекс", Species = "Собака", Age = 5, Color = "Чорний" },
    new Animal { Id = 3, Name = "Барсик", Species = "Кіт", Age = 7, Color = "Сірий" },
    new Animal { Id = 4, Name = "Бобік", Species = "Собака", Age = 2, Color = "Коричневий" }
        ];

        public IActionResult Index()
        {
            return View(animals);
        }
        public IActionResult Cards()
        {
            return View(animals);
        }

        public IActionResult Details(int id)
        {
            var animal = animals.FirstOrDefault(x => x.Id == id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }
    }
}