using MedPoint.Appointments.Core.Interfaces;
using MedPoint.Appointments.Shell.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace MedPoint.Appointments.Shell
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppointmentShell(this IServiceCollection services)
        {
            services.AddSingleton<IAppointmentRepository, AppointmentRepository>();
            return services;
        }
    }
}
