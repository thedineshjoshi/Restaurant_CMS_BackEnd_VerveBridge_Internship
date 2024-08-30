using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SocialLink
    {
        public Guid id { get; set; }
        public string PlatformName { get; set; }
        public string Link { get; set; }
    }
}
