using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Header.Queries.GetHeader
{
    public class HeaderDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string LogoUrl { get; set; }
        public string BookTableButtonText { get; set; }
        public string BookTableButtonLink { get; set; }
    }
}
