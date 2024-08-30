using Application.Common.Interfaces;
using Domain;
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
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateTestimonialCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var testimonial = new CustomerTestimonial
            {
                CustomerName = request.Author,
                CustomerSaying = request.Content,
                CustomerImageUrl = request.ImageUrl
            };

            _context.Testimonials.Add(testimonial);
            await _context.SaveChangesAsync(cancellationToken);

            return testimonial.id;
        }
    }
}
