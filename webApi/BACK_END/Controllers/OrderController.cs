using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllOrders()
        {
            var orders = _orderService.GetList();
            if (orders.Success)
            {
                return Ok(orders.Data);
            }

            return BadRequest(orders.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetOrderById(int id)
        {
            var orders = _orderService.Get(id);
            if (orders.Success)
            {
                return Ok(orders.Data);
            }
            return BadRequest(orders.Message);
        }   

        [HttpPost("add")]
        public IActionResult AddOrder(Order order)
        {
            var orders = _orderService.Add(order);
            if (orders.Success)
            {
                return Ok(orders.Message);
            }
            return BadRequest(orders.Message);
        }

        [HttpPut("update")]
        public IActionResult UpdateOrder(Order order)
        {
            var orders = _orderService.Update(order);
            if (orders.Success)
            {
                return Ok(orders.Message);
            }
            return BadRequest(orders.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteOrder(Order order)
        {
            var orders = _orderService.Delete(order);
            if (orders.Success)
            {
                return Ok(orders.Message);
            }
            return BadRequest(orders.Message);
        }   
    }
}
