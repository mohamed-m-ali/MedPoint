using MedPoint.Bookings.Application.Common.Interfaces;
using MedPoint.Bookings.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace MedPoint.Bookings.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBookingInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IBookingRepository, InMemoryBookingRepository>();
            return services;
        }
    }
}
