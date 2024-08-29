using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Reservation.Commands.CreateReservation
{
    public class CreateReservationCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public int Guests { get; set; }
        public string Message { get; set; }
    }
}
