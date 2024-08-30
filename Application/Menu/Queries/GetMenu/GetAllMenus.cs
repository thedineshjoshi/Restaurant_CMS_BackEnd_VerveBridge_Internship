using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Menu.Queries.GetMenu
{
    public class GetAllMenusQuery : IRequest<List<MenuCategoryDto>>
    {
    }
    public class GetAllMenusQueryHandler : IRequestHandler<GetAllMenusQuery, List<MenuCategoryDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllMenusQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<MenuCategoryDto>> Handle(GetAllMenusQuery request, CancellationToken cancellationToken)
        {
            var menuCategories = await _context.Menus
                .Include(mc => mc.MenuItems)
                .ToListAsync(cancellationToken);

            return menuCategories.Select(category => new MenuCategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Items = category.MenuItems.Select(item => new MenuItemDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    ImageUrl = item.ImageUrl
                }).ToList()
            }).ToList();
        }
    }
}
