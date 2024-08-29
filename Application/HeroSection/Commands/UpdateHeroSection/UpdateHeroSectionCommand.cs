using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HeroSection.Commands.UpdateHeroSection
{
    public class UpdateHeroSectionCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string BackgroundImageUrl { get; set; }
    }
}
