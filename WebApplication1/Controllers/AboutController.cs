using Application.AboutUs.Commands.UpdateAboutUs;
using Application.AboutUs.Queries.GetAboutUs;
using Application.Common.Interfaces;
using Application.Features.Queries.GetFeature;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class AboutController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public AboutController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<AboutController>
        [HttpGet]
        public async Task<IActionResult> GetAbout()
        {
            var result = await _mediator.Send(new GetAboutUsQuery());
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // GET api/<AboutController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AboutController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AboutController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAboutUs(Guid id, UpdateAboutUsCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<AboutController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

