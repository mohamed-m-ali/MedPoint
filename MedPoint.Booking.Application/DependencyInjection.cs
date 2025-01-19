using MedPoint.Notification.Gateway;
using MedPoint.Notification.Sender;
using Microsoft.Extensions.DependencyInjection;

namespace MedPoint.Bookings.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBookingApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
            services.AddSingleton<InboundGateway, InboundGateway>();
            services.AddSingleton<INotificationSender, NotificationSender>();
            return services;
        }
    }
}
