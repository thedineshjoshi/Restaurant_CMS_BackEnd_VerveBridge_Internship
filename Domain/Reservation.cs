using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OnlineReservation
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public int NumberOfPeople { get; set; }
        public string SpecialRequest { get; set; }
    }
}
