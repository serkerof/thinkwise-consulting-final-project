using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;



namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetList();
            if (users.Success)
            {
                return Ok(users.Data);
            }

            return BadRequest(users.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetUserById(int id)
        {
            var users = _userService.Get(id);
            if (users.Success)
            {
                return Ok(users.Data);
            }
            return BadRequest(users.Message);
        }   

    
        [HttpPost("add")]
        public IActionResult AddUser(User user)
        {
            var users = _userService.Add(user);
            if (users.Success)
            {
                return Ok(users.Message);
            }
            return BadRequest(users.Message);
        }

        [HttpPut("update")]
        public IActionResult UpdateUser(User user)
        {
            var users = _userService.Update(user);
            if (users.Success)
            {
                return Ok(users.Message);
            }
            return BadRequest(users.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteUser(User user)
        {
            var users = _userService.Delete(user);
            if (users.Success)
            {
                return Ok(users.Message);
            }
            return BadRequest(users.Message);
        }   
    }
}
