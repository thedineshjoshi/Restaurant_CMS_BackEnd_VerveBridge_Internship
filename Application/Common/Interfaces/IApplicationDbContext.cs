using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<About>AboutUs { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<FooterBottom> Footers { get; set; }
        DbSet<SocialLink> SocialLinks { get; set; }
        DbSet<HeaderTop> Headers { get; set; }
        DbSet<Hero> HeroSections { get; set; }
        DbSet<MenuCategory> Menus { get; set; }
        DbSet<MenuItem> MenuItems { get; set; }
        DbSet<OnlineReservation> Reservations { get; set; }
        DbSet<TeamMember> TeamMembers { get; set; }
        DbSet<CustomerTestimonial> Testimonials { get; set; }

        Task <int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
