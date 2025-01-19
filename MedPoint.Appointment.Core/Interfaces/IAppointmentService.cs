using MedPoint.Appointments.Core.Entities;

namespace MedPoint.Appointments.Core.Interfaces
{
    public interface IAppointmentService
    {
        Task<IEnumerable<Appointment>> GetAppointmentsAsync();
        Task<Appointment> UpdateAppointmentAsync(Appointment appointment);
    }
}