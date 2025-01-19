using MedPoint.Appointments.Core.Entities;
using MedPoint.Appointments.Core.Interfaces;
using MedPoint.Data.InMemoryDatabase;

namespace MedPoint.Appointments.Shell.Persistence
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public Task<IEnumerable<Appointment>> GetAppointmentsAsync()
        {
            var appointments = Database.Bookings.Select(a => new Appointment(a.Id, a.SlotId, a.PatientId, a.PatientName, a.ReservedAt));
            return Task.FromResult(appointments);
        }

        public Task<Appointment> UpdateAppointmentAsync(Appointment appointment)
        {
            var existingAppointment = Database.Bookings.FirstOrDefault(a => a.Id == appointment.Id);
            if (existingAppointment == null)
            {
                throw new ArgumentException("Appointment not found");
            }
            existingAppointment = new Data.InMemoryDatabase.Tables.Booking(
                appointment.Id,
                appointment.SlotId,
                appointment.PatientId,
                appointment.PatientName,
                appointment.ReservedAt);
            return Task.FromResult(appointment);
        }
    }
}
