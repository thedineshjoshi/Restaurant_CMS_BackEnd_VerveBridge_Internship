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
        public string IconUrl { get; set; }
    }
}
