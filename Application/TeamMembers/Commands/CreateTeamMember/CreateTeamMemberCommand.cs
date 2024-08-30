using Application.Common.Interfaces;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TeamMembers.Commands.CreateTeamMember
{
    public class CreateTeamMemberCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }

    }

    public class CreateTeamMemberCommandHandler : IRequestHandler<CreateTeamMemberCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateTeamMemberCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateTeamMemberCommand request, CancellationToken cancellationToken)
        {
            var teamMember = new TeamMember
            {
                Name = request.Name,
                Designation = request.Position,
                ImageUrl = request.ImageUrl,
                FacebookLink = request.FacebookLink,
                TwitterLink = request.TwitterLink,
                InstagramLink = request.InstagramLink
            };

            _context.TeamMembers.Add(teamMember);
            await _context.SaveChangesAsync(cancellationToken);

            return teamMember.id;
        }
    }
}
