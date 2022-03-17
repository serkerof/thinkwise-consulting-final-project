using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllAdmins()
        {
            var admins = _adminService.GetList();
            if (admins.Success)
            {
                return Ok(admins.Data);
            }

            return BadRequest(admins.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetAdminById(int id)
        {
            var admins = _adminService.Get(id);
            if (admins.Success)
            {
                return Ok(admins.Data);
            }
            return BadRequest(admins.Message);
        }

        [HttpPost("add")]
        public IActionResult AddAdmin(Admin admin)
        {
            var admins = _adminService.Add(admin);
            if (admins.Success)
            {
                return Ok(admins.Message);
            }
            return BadRequest(admins.Message);
        }

        [HttpPut("update")]
        public IActionResult UpdateAdmin(Admin admin)
        {
            var admins = _adminService.Update(admin);
            if (admins.Success)
            {
                return Ok(admins.Message);
            }
            return BadRequest(admins.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteAdmin(Admin admin)
        {
            var admins = _adminService.Delete(admin);
            if (admins.Success)
            {
                return Ok(admins.Message);
            }
            return BadRequest(admins.Message);
        }
    }

}