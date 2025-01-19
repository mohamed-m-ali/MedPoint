using MedPoint.Appointments.Core.Interfaces;
using MedPoint.Appointments.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MedPoint.Appointments.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppointmentCore(this IServiceCollection services)
        {
            services.AddSingleton<IAppointmentService, AppointmentService>();
            return services;
        }
    }
}
