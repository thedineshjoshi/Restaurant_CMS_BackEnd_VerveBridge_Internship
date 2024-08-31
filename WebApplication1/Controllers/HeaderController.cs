using Application.Common.Interfaces;
using Application.Header.Commands.UpdateHeader;
using Application.Header.Queries.GetHeader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class HeaderController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public HeaderController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<HeaderController>
        [HttpGet]
        public async Task<IActionResult> GetHeader()
        {
            var result = await _mediator.Send(new GetHeaderQuery());
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // GET api/<HeaderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HeaderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HeaderController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHeader(Guid id, UpdateHeaderCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<HeaderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
