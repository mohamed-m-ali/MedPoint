using MedPoint.Bookings.Domain.Entities;

namespace MedPoint.Bookings.Application.Common.Interfaces
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Slot>> GetAvailableSlotsAsync();
        Task<Guid> CreateBookingAsync(Booking booking);
    }
}
