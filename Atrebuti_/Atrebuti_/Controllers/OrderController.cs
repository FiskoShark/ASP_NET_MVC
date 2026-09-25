using Atrebuti_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atrebuti_.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private static List<OrderModel> orders = new List<OrderModel>();

        // GET /api/orders 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(orders);
        }

        // GET /api/orders/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = orders.FirstOrDefault(x => x.id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // GET /api/orders/search?title=Phone
        [HttpGet("search")]
        public IActionResult Search(string title)
        {
            var result = orders
                .Where(x => x.title.Contains(title))
                .ToList();
            return Ok(result);
        }

        // POST /api/orders
        [HttpPost]
        public IActionResult Create(OrderModel order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            order.id = orders.Count + 1;
            orders.Add(order);
            return Ok(order);
        }
    }
}
