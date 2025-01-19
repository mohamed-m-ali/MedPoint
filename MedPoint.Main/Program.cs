
using MedPoint.Availability.BusinessLogic.Services;
using MedPoint.Availability.DataAccess.Repositories;
using MedPoint.Bookings.Application;
using MedPoint.Appointments.Core;
using MedPoint.Appointments.Shell;
namespace MedPoint.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<AvailabilityService,AvailabilityService>();
            builder.Services.AddSingleton<AvailabilityRepository, AvailabilityRepository>();
            builder.Services.AddBookingApplication();
            builder.Services.AddBookingInfrastructure();
            builder.Services.AddAppointmentCore();
            builder.Services.AddAppointmentShell();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
