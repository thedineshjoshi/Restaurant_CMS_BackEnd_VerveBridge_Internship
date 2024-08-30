using Application.Social_Links.Queries.GetAllSocialLinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Footer.Queries.GetFooter
{
    public class FooterDto
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<SocialLinkDto> SocialLinks { get; set; }
    }
}
