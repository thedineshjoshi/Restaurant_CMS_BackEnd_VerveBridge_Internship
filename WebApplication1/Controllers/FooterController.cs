using Application.Common.Interfaces;
using Application.Footer.Commands.UpdateFooter;
using Application.Footer.Queries.GetFooter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class FooterController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public FooterController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<FooterController>
        [HttpGet]
        public async Task<IActionResult> GetFooter()
        {
            var result = await _mediator.Send(new GetFooterQuery());
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // GET api/<FooterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FooterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FooterController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFooter(Guid id, UpdateFooterCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<FooterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
