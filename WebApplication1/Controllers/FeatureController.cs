using Application.Common.Interfaces;
using Application.Features.Commands.CreateFeature;
using Application.Features.Queries.GetFeature;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class FeatureController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public FeatureController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<FeatureController>
        [HttpGet]
        public async Task<IActionResult> GetAllFeatures()
        {
            var result = await _mediator.Send(new GetAllFeaturesQuery());
            return Ok(result);
        }

        // GET api/<FeatureController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FeatureController>
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAllFeatures), new { id }, command);
        }

        // PUT api/<FeatureController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFeature(Guid id, CreateFeatureCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

    // DELETE api/<FeatureController>/5
    [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
