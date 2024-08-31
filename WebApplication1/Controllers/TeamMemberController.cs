using Application.Common.Interfaces;
using Application.TeamMembers.Commands.CreateTeamMember;
using Application.TeamMembers.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class TeamMemberController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public TeamMemberController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<TeamMemberController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TeamMemberController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllTeamMembers()
        {
            var result = await _mediator.Send(new GetAllTeamMembersQuery());
            return Ok(result);
        }

        // POST api/<TeamMemberController>
        [HttpPost]
        public async Task<IActionResult> CreateTeamMember(CreateTeamMemberCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAllTeamMembers), new { id }, command);
        }

        // PUT api/<TeamMemberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamMemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
