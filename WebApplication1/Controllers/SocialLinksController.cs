using Application.Common.Interfaces;
using Application.Social_Links.Commands.CreateSocailLink;
using Application.Social_Links.Queries.GetAllSocialLinks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class SocialLinksController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public SocialLinksController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<SocialLinksController>
        [HttpGet]
        public async Task<IActionResult> GetAllSocialLinks()
        {
            var result = await _mediator.Send(new GetAllSocialLinksQuery());
            return Ok(result);
        }

        // GET api/<SocialLinksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SocialLinksController>
        [HttpPost]
        public async Task<IActionResult> CreateSocialLink(CreateSocialLinkCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAllSocialLinks), new { id }, command);
        }

        // PUT api/<SocialLinksController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSocialLink(Guid id, CreateSocialLinkCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<SocialLinksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
