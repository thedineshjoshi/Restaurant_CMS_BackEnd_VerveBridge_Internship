using Application.Common.Interfaces;
using Domain.AboutUs;
using Domain.Chefs;
using Domain.Features;
using Domain.Footer;
using Domain.Header;
using Domain.HeroSection;
using Domain.Menu;
using Domain.OnlineResevation;
using Domain.Testimonial;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }
        public DbSet<MenuCategory> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuCategory>()
           .HasMany(c => c.MenuItems)
           .WithOne(i => i.MenuCategory)
           .HasForeignKey(i => i.MenuCategoryId)
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.UserClaims)
                .WithOne()
                .HasForeignKey(c => c.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.UserRoles)
                .WithOne()
                .HasForeignKey(r => r.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationRole>()
                .HasMany(r => r.RoleClaims)
                .WithOne()
                .HasForeignKey(c => c.RoleId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationRole>()
                .HasMany(r => r.UserRoles)
                .WithOne()
                .HasForeignKey(r => r.RoleId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            //Roles Seeding in my Database;
            var AdminRoleId = Guid.NewGuid();
            modelBuilder.Entity<ApplicationRole>().HasData(
                    new ApplicationRole
                    {

                        Id = AdminRoleId,
                        Name = "Admin",
                        Description = "Can Manage Everything",
                        NormalizedName = "ADMIN",
                        ConcurrencyStamp = Guid.NewGuid().ToString()

                    }
                );

            //User_Seeding based on the above Role
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var user = new ApplicationUser
            {
                Id = Guid.NewGuid(),
                UserName = "Dinesh25",
                NormalizedUserName = "DINESH25",
                Email = "dineshjoshi0025@gmail.com",
                NormalizedEmail = "DINESHJOSHI0025@GMAIL.COM",
                EmailConfirmed = true,
                IsActive = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()

            };
            user.PasswordHash = passwordHasher.HashPassword(user, "@Dineshdj25"); // Set the password hash

            // Seeding users
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Seeding the user-role relationship
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = user.Id,
                    RoleId = AdminRoleId
                }
            );
        }
    }
}

