using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OnlineResevation
{
    public class Reservation
    {
        public Guid id { get; set; } // Primary Key

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; } // Name of the customer making the reservation

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string CustomerEmail { get; set; } // Customer's email

        [Required]
        public DateTime ReservationDateTime { get; set; } // Date and time of the reservation

        [Required]
        [Range(1, 20)] // Adjust the range based on your restaurant's capacity
        public int NumberOfPeople { get; set; } // Number of people for the reservation

        [MaxLength(500)]
        public string SpecialRequest { get; set; } // Special requests or notes (optional)

        public bool IsConfirmed { get; set; } = false; // Status of the reservation, default to false
    }
}
