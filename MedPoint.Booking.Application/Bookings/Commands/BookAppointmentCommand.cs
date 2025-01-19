using MediatR;
using MedPoint.Bookings.Domain.Entities;
namespace MedPoint.Bookings.Application.Bookings.Commands
{
    public record BookAppointmentCommand(Booking Booking) : IRequest<Guid>;
}
