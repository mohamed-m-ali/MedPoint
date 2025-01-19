using MediatR;
using MedPoint.Bookings.Application.Common.Interfaces;
using MedPoint.Bookings.Domain.Entities;

namespace MedPoint.Bookings.Application.Bookings.Queries
{
    public class GetAvailableSlotsQueryHandler : IRequestHandler<GetAvailableSlotsQuery, IEnumerable<Slot>>
    {
        private readonly IBookingRepository _bookingRepository;

        public GetAvailableSlotsQueryHandler(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public async Task<IEnumerable<Slot>> Handle(GetAvailableSlotsQuery request, CancellationToken cancellationToken)
        {
            var result = await _bookingRepository.GetAvailableSlotsAsync();
            return result;
        }
    }
}
