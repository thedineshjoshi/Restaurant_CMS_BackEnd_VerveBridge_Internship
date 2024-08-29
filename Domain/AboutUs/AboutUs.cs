using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AboutUs
{
    public class AboutUs
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainImageUrl { get; set; }
        public int YearsOfExperience { get; set; }
        public int MasterChefsCount { get; set; }
    }

}
