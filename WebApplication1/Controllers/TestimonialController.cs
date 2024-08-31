using Application.Common.Interfaces;
using Application.Testimonial.Commands.CreateTestimonial;
using Application.Testimonial.Queries.GetTestimonial;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class TestimonialController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public TestimonialController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<TestimonialController>
        [HttpGet]
        public async Task<IActionResult> GetAllTestimonials()
        {
            var result = await _mediator.Send(new GetAllTestimonialsQuery());
            return Ok(result);
        }

        // GET api/<TestimonialController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestimonialController>
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAllTestimonials), new { id }, command);
        }

        // PUT api/<TestimonialController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestimonialController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
