using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Footer
{
    public class Footer
    {
        public Guid id { get; set; }
        public string CompanyInfo { get; set; }
        public string ContactInfo { get; set; }
        public List<SocialLink> SocialLinks { get; set; }
        public string NewsletterText { get; set; }
    }

    public class SocialLink
    {
        public Guid id { get; set; }
        public string PlatformName { get; set; }
        public string Link { get; set; }
    }

}
