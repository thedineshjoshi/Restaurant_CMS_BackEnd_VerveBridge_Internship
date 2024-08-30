using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AboutUs.Commands.UpdateAboutUs
{
    public class UpdateAboutUsCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    public class UpdateAboutUsCommandHandler : IRequestHandler<UpdateAboutUsCommand,Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAboutUsCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(UpdateAboutUsCommand request, CancellationToken cancellationToken)
        {
            var aboutUs = new About
            {
                Title = request.Title,
                Description = request.Description,
                MainImageUrl = request.ImageUrl,
            };
            _context.AboutUs.Add(aboutUs);
            await _context.SaveChangesAsync(cancellationToken);
            return aboutUs.id;
        }
    }
}
