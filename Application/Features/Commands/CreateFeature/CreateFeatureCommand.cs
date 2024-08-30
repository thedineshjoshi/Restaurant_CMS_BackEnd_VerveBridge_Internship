using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.CreateFeature
{
    public class CreateFeatureCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }

    public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand,Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateFeatureCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            var feature = new Feature
            {
                Title = request.Name,
                Description = request.Description,
                IconUrl = request.IconUrl
            };

            _context.Features.Add(feature);
            await _context.SaveChangesAsync(cancellationToken);

            return feature.id;
        }
    }
}
