using Application.User.Commands.CreateRole;
using Application.User.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedAdminRole")]
    [ApiController]
    public class AppController : ApiControllerBase
    {
        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole([FromBody] RoleCommand roleCommand)
        {
            var result = await Mediator.Send(roleCommand);
            if (result.Succeded)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserCommand userCommand)
        {
            var result = await Mediator.Send(userCommand);
            if (result.Succeded)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
