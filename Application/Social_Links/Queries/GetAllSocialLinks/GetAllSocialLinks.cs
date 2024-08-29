using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Social_Links.Queries.GetAllSocialLinks
{
    public class GetAllSocialLinksQuery : IRequest<List<SocialLinkDto>>
    {
    }
}
