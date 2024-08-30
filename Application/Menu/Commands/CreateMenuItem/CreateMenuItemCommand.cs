using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Menu.Commands.CreateMenuItem
{
    public class CreateMenuItemCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid MenuCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }

    public class CreateMenuItemCommandHandler : IRequestHandler<CreateMenuItemCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateMenuItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateMenuItemCommand request, CancellationToken cancellationToken)
        {
            var menuItem = new MenuItem
            {
                MenuCategoryId = request.MenuCategoryId,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                ImageUrl = request.ImageUrl
            };

            _context.MenuItems.Add(menuItem);
            await _context.SaveChangesAsync(cancellationToken);

            return menuItem.Id;
        }
    }
}
