using Application.Common.Interfaces;
using Application.Menu.Commands.CreateMenuItem;
using Application.Menu.Queries.GetMenu;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public MenuController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<MenuController>
        [HttpGet]
        public async Task<IActionResult> GetAllMenus()
        {
            var result = await _mediator.Send(new GetAllMenusQuery());
            return Ok(result);
        }

        // GET api/<MenuController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MenuController>
        [HttpPost]
        public async Task<IActionResult> CreateMenuItem(CreateMenuItemCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAllMenus), new { id }, command);
        }

        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMenuItem(Guid id, CreateMenuItemCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
