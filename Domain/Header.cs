using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HeaderTop
    {
        public Guid id { get; set; }
        public string LogoUrl { get; set; }
        public List<NavigationItem> NavigationItems { get; set; }
        public string BookTableButtonText { get; set; }
        public string BookTableButtonLink { get; set; }
    }

    public class NavigationItem
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
