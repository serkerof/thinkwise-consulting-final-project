using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllServices()
        {
            var services = _serviceService.GetList();
            if (services.Success)
            {
                return Ok(services.Data);
            }

            return BadRequest(services.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetServiceById(int id)
        {
            var services = _serviceService.Get(id);
            if (services.Success)
            {
                return Ok(services.Data);
            }
            return BadRequest(services.Message);
        }

        [HttpPost("add")]
        public IActionResult AddService(Service service)
        {
            var services = _serviceService.Add(service);
            if (services.Success)
            {
                return Ok(services.Message);
            }
            return BadRequest(services.Message);
        }

        [HttpPut("update")]
        public IActionResult UpdateService(Service service)
        {
            var services = _serviceService.Update(service);
            if (services.Success)
            {
                return Ok(services.Message);
            }
            return BadRequest(services.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteService(Service service)
        {
            var services = _serviceService.Delete(service);
            if (services.Success)
            {
                return Ok(services.Message);
            }
            return BadRequest(services.Message);
        }


    }
}