using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Menu
{
    public class MenuSection
    {
        public Guid id { get; set; } // Primary Key

        [Required]
        public string Name { get; set; } // e.g., Appetizers, Mains

        public string Description { get; set; } // Optional description of the section

        public int SortOrder { get; set; } // Order in which sections should appear

        // Foreign key to the Menu
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }

        // Navigation property to represent the relationship with MenuItems
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
