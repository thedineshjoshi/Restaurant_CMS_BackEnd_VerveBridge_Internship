using Application.User.Commands.LoginUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ApiControllerBase
    {
        [HttpPost("Login")]
        public async Task<ActionResult<TokenResult>> Login([FromBody] LoginUserCommand loginuserCommand)
        {
            var result = await Mediator.Send(loginuserCommand);
            if (result.Succeeded)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
