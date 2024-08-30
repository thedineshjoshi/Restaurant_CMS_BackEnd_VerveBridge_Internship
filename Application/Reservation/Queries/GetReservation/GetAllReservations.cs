using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
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

    public class GetAllReservationsQueryHandler : IRequestHandler<GetAllReservationsQuery, List<ReservationDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllReservationsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ReservationDto>> Handle(GetAllReservationsQuery request, CancellationToken cancellationToken)
        {
            var reservations = await _context.Reservations.ToListAsync(cancellationToken);

            return reservations.Select(reservation => new ReservationDto
            {
                Id = reservation.id,
                Name = reservation.Name,
                Email = reservation.Email,
                Date = reservation.ReservationDateTime,
                Guests = reservation.NumberOfPeople,
                Message = reservation.SpecialRequest
            }).ToList();
        }
    }
}
