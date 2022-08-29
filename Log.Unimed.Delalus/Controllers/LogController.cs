using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Log.Unimed.Controllers
{
    public class LogController : Controller
    {
        private readonly IMediator _handle;


        [HttpPost("post")]
        public async Task<IActionResult> Post([FromQuery] PostLogQuery model)
        {
            var result = await _handle.Send(model);

            return BadRequest(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] GetLogQuery model)
        {
            var result = await _handle.Send(model);

            return BadRequest(result);
        }

    }
}
