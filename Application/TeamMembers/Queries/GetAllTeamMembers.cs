using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TeamMembers.Queries
{
    public class GetAllTeamMembersQuery : IRequest<List<TeamMemberDto>>
    {
    }
}
