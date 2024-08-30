using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Testimonial.Queries.GetTestimonial
{
    public class GetAllTestimonialsQuery : IRequest<List<TestimonialDto>>
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }

    public class GetAllTestimonialsQueryHandler : IRequestHandler<GetAllTestimonialsQuery, List<TestimonialDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllTestimonialsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TestimonialDto>> Handle(GetAllTestimonialsQuery request, CancellationToken cancellationToken)
        {
            var testimonials = await _context.Testimonials.ToListAsync(cancellationToken);

            return testimonials.Select(testimonial => new TestimonialDto
            {
                Id = testimonial.id,
                Author = testimonial.CustomerName,
                Content = testimonial.CustomerSaying,
                ImageUrl = testimonial.CustomerImageUrl
            }).ToList();
        }
    }
}
