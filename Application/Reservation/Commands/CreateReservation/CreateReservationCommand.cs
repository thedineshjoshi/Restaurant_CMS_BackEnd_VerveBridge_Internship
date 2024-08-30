using Application.Common.Interfaces;
using Domain;
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

    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateReservationCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservation = new OnlineReservation
            {
                Name = request.Name,
                Email = request.Email,
                ReservationDateTime = request.Date,
                NumberOfPeople = request.Guests,
                SpecialRequest = request.Message
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync(cancellationToken);

            return reservation.id;
        }
    }
}
