using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllEmails()
        {
            var emails = _emailService.GetList();
            if (emails.Success)
            {
                return Ok(emails.Data);
            }

            return BadRequest(emails.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetEmailById(int id)
        {
            var emails = _emailService.Get(id);
            if (emails.Success)
            {
                return Ok(emails.Data);
            }
            return BadRequest(emails.Message);
        }

        [HttpPost("add")]
        public IActionResult AddEmail(Email email)
        {
            var emails = _emailService.Add(email);
            if (emails.Success)
            {
                return Ok(emails.Message);
            }
            return BadRequest(emails.Message);
        }

        [HttpPut("update")]
        public IActionResult UpdateEmail(Email email)
        {
            var emails = _emailService.Update(email);
            if (emails.Success)
            {
                return Ok(emails.Message);
            }
            return BadRequest(emails.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteEmail(Email email)
        {
            var emails = _emailService.Delete(email);
            if (emails.Success)
            {
                return Ok(emails.Message);
            }
            return BadRequest(emails.Message);
        }
    }
}
