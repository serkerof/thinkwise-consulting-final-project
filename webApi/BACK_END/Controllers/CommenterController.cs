using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;


namespace BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommenterController : ControllerBase
    {
        private readonly ICommenterService _commenterService;

        public CommenterController(ICommenterService commenterService)
        {
            _commenterService = commenterService;
        }

        [HttpGet("getall")]
        public IActionResult GetAllCommenter()
        {
            var commenter = _commenterService.GetList();
            if (commenter.Success)
            {
                return Ok(commenter.Data);
            }

            return BadRequest(commenter.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetCommenterById(int id)
        {
            var commenter = _commenterService.Get(id);
            if (commenter.Success)
            {
                return Ok(commenter.Data);
            }
            return BadRequest(commenter.Message);
        }

        [HttpPost("add")]
        public IActionResult AddCommenter(Commenter commenter)
        {
            var commenters = _commenterService.Add(commenter);
            if (commenters.Success)
            {
                return Ok(commenters.Message);
            }
            return BadRequest(commenters.Message);
        }

        [HttpPut("update")]
        public IActionResult UpdateCommenter(Commenter commenter)
        {
            var commenters = _commenterService.Update(commenter);
            if (commenters.Success)
            {
                return Ok(commenters.Message);
            }
            return BadRequest(commenters.Message);
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCommenter(Commenter commenter)
        {
            var commenters = _commenterService.Delete(commenter);
            if (commenters.Success)
            {
                return Ok(commenters.Message);
            }
            return BadRequest(commenters.Message);
        }
    }
}
