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
    }
}
