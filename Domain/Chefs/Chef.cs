using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Chefs
{
    public class Chef
    {
        public Guid id { get; set; } // Primary Key

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } // Name of the team member

        [Required]
        public string Designation { get; set; } // Team member's role/designation (e.g., Chef, Manager)
        public string ImageUrl { get; set; } // URL or path to the team member's image
        public string FacebookLink { get; set; } // Link to Facebook profile
        public string TwitterLink { get; set; } // Link to Twitter profile
        public string InstagramLink { get; set; } // Link to Instagram profile
    }
}
