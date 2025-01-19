using MediatR;
using MedPoint.Bookings.Domain.Entities;

namespace MedPoint.Bookings.Application.Bookings.Queries
{
    public record GetAvailableSlotsQuery() : IRequest<IEnumerable<Slot>>;
}
