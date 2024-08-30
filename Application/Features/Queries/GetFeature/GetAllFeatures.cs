using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.GetFeature
{
    public class GetAllFeaturesQuery : IRequest<List<FeatureDto>>
    {
    }
    public class GetAllFeaturesQueryHandler : IRequestHandler<GetAllFeaturesQuery, List<FeatureDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllFeaturesQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FeatureDto>> Handle(GetAllFeaturesQuery request, CancellationToken cancellationToken)
        {
            var features = await _context.Features.ToListAsync(cancellationToken);

            return features.Select(feature => new FeatureDto
            {
                Id = feature.id,
                Name = feature.Title,
                Description = feature.Description,
                IconUrl = feature.IconUrl
            }).ToList();
        }
    }
}
