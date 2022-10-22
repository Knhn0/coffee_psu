using CoffeePsu.Domain.Contracts;
using CoffeePsu.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CoffeePsu.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "This is terminal for Coffee" };
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok($"Coffee Id is {id}");
        }

        [HttpPost]
        public ActionResult Post(OrderModel order)
        {
            _orderService.CreateOrder(order);
            var result = _orderService.CreateOrder(order);
            if (result == null)
            {
                return BadRequest("Your result is null");
            }
            return Ok($"Ok. Your result is {result}");
        }
    }
}
