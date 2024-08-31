using Application.Common.Interfaces;
using Application.HeroSection.Commands.UpdateHeroSection;
using Application.HeroSection.Queries.GetHeroSection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class HeroSectionController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public HeroSectionController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<HeroSectionController>
        [HttpGet]
        public async Task<IActionResult> GetHeroSection()
        {
            var result = await _mediator.Send(new GetHeroSectionQuery());
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // GET api/<HeroSectionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HeroSectionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HeroSectionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHeroSection(Guid id, UpdateHeroSectionCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<HeroSectionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
