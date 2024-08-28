using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Menu
{
    public class MenuItem
    {
        public Guid id { get; set; } // Primary Key

        [Required]
        public string Name { get; set; } // e.g., Caesar Salad, Grilled Chicken

        public string Description { get; set; } // Description of the dish
        public decimal Price { get; set; } // Price of the item, with a sensible range

        public string DietaryInfo { get; set; } // e.g., Vegetarian, Gluten-Free

        public string ImageUrl { get; set; } // URL or path to an image of the dish

        public bool IsAvailable { get; set; } // Availability status
        public Guid MenuSectionId { get; set; }
        public MenuSection MenuSection { get; set; }
    }
}
