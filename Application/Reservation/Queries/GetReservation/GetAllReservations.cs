using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Reservation.Queries.GetReservation
{
    public class GetAllReservationsQuery : IRequest<List<ReservationDto>>
    {
    }
}
