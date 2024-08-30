using Application.Common.Interfaces;
using Application.TeamMembers.Commands.CreateTeamMember;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Social_Links.Commands.CreateSocailLink
{
    public class CreateSocialLinkCommand : IRequest<Guid>
    {
        public string Platform { get; set; }
        public string Url { get; set; }
    }

    public class CreateSocialLinkCommandHandler : IRequestHandler<CreateSocialLinkCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateSocialLinkCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateSocialLinkCommand request, CancellationToken cancellationToken)
        {
            var socialLink = new SocialLink
            {
                PlatformName = request.Platform,
                Link = request.Url,
            };

            _context.SocialLinks.Add(socialLink);
            await _context.SaveChangesAsync(cancellationToken);

            return socialLink.id;
        }
    }
}
