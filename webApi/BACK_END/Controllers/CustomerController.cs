using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;


namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllCustomers()
        {
            var customers = _customerService.GetList();

            if (customers.Success)
            {
                return Ok(customers.Data);
            }

            return BadRequest(customers.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetCustomerById(int id)
        {
            var customers = _customerService.Get(id);
            if(customers.Success)
            {
                return Ok(customers.Data);
            }
            return BadRequest(customers.Message);
        }

        [HttpPost("add")]
        public IActionResult AddCustomer(Customer customer)
        {
            var customers = _customerService.Add(customer);
            if(customers.Success)
            {
                return Ok(customers.Message);
            }
            return BadRequest(customers.Message);
        }

        [HttpPut("update")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var customers = _customerService.Update(customer);
            if (customers.Success)
            {
                return Ok(customers.Message);
            }
            return BadRequest(customers.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCustomer(Customer customer)
        {
            var customers = _customerService.Delete(customer);

            if (customers.Success)
            {
                return Ok(customers.Message);
            }
            return BadRequest(customers.Message);


        }

    }
}
