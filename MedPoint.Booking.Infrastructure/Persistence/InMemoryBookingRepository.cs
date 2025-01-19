using MedPoint.Bookings.Application.Common.Interfaces;
using MedPoint.Bookings.Domain.Entities;
using MedPoint.Data.InMemoryDatabase;

namespace MedPoint.Bookings.Infrastructure.Persistence
{
    public class InMemoryBookingRepository : IBookingRepository
    {


        public Task<IEnumerable<Slot>> GetAvailableSlotsAsync()
        {
            var slots = Database.Slots.Where(s => !s.IsReserved).Select(s => new Slot(s.Id, s.Time, s.DoctorId, s.DoctorName, s.IsReserved, s.Cost));
            return Task.FromResult(slots);
        }


        Task<Guid> IBookingRepository.CreateBookingAsync(Booking booking)
        {
            Database.Bookings.Add(new Data.InMemoryDatabase.Tables.Booking(booking.Id, booking.SlotId, booking.PatientId, booking.PatientName, booking.ReservedAt));
            return Task.FromResult(booking.Id);
        }
    }
}
