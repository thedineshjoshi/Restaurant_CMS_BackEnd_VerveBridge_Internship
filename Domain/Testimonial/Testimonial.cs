using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Testimonial
{
    public class Testimonial
    {
        public Guid id { get; set; }

        [Required]
        public string CustomerSaying { get; set; } // The testimonial or feedback from the customer

        [Required]
        public string CustomerName { get; set; } // The name of the customer

        public string ImageUrl { get; set; } // URL or path to the customer's image
    }
}
