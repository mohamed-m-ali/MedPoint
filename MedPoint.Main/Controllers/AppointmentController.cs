using MedPoint.Appointments.Core.Entities;
using MedPoint.Appointments.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedPoint.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Appointment>> GetAppointmentsAsync()
        {
            return await _appointmentService.GetAppointmentsAsync();
        }

        [HttpPut]
        public async Task<Appointment> UpdateAppointmentAsync(Appointment appointment)
        {
            return await _appointmentService.UpdateAppointmentAsync(appointment);
        }
    }
}
