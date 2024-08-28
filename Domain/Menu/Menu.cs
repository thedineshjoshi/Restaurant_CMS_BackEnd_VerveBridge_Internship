using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Menu
{
    public class Menu
    {
        public Guid id { get; set; } // Primary Key

        [Required]
        public string Name { get; set; } // e.g., Breakfast Menu, Lunch Menu

        public string Description { get; set; } // Optional description of the menu

        [Required]
        public DateTime ActiveFrom { get; set; } // When the menu becomes active

        public DateTime? ActiveTo { get; set; } // When the menu expires, if applicable

        [Required]
        public bool IsActive { get; set; } // Whether the menu is currently active

        // Navigation property to represent the relationship with MenuSections
        public ICollection<MenuSection> MenuSections { get; set; }
    }

}
