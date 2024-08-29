using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Testimonial.Commands.CreateTestimonial
{
    public class CreateTestimonialCommand : IRequest<Guid>
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }
}
