using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HeroSection.Queries.GetHeroSection
{
    public class HeroSectionDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
    }
}
