using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AboutUs.Queries.GetAboutUs
{
    public class GetAboutUsQuery : IRequest<AboutUsDto>
    {
    }

    public class GetAboutUsQueryHandler : IRequestHandler<GetAboutUsQuery, AboutUsDto>
    {
        private readonly IApplicationDbContext _context;

        public GetAboutUsQueryHandler(IApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<AboutUsDto> Handle(GetAboutUsQuery request, CancellationToken cancellationToken)
        {
            var aboutUs = await _context.AboutUs.FirstOrDefaultAsync(cancellationToken);

            if (aboutUs == null)
            {
                return null;
            }

            return new AboutUsDto
            {
                Id = aboutUs.id,
                Title = aboutUs.Title,
                Description = aboutUs.Description,
                ImageUrl = aboutUs.MainImageUrl
            };
        }
    }
}
