using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetList();
            if (employees.Success)
            {
                return Ok(employees.Data);
            }

            return BadRequest(employees.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetEmployeeById(int id)
        {
            var employees = _employeeService.Get(id);
            if (employees.Success)
            {
                return Ok(employees.Data);
            }
            return BadRequest(employees.Message);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var employees = _employeeService.Add(employee);
            if (employees.Success)
            {
                return Ok(employees.Message);
            }
            return BadRequest(employees.Message);
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var employees = _employeeService.Update(employee);
            if (employees.Success)
            {
                return Ok(employees.Message);
            }
            return BadRequest(employees.Message);
        }

        [HttpDelete]
        public IActionResult DeleteEmployee(Employee employee)
        {
            var employees = _employeeService.Delete(employee);
            if (employees.Success)
            {
                return Ok(employees.Message);
            }
            return BadRequest(employees.Message);
        }
    }
}
