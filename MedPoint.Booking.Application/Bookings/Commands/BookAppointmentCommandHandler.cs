using MediatR;
using MedPoint.Bookings.Application.Common.Interfaces;
using MedPoint.Notification.Gateway;

namespace MedPoint.Bookings.Application.Bookings.Commands
{
    public class BookAppointmentCommandHandler : IRequestHandler<BookAppointmentCommand, Guid>
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly InboundGateway _inboundGateway;

        public BookAppointmentCommandHandler(IBookingRepository bookingRepository, InboundGateway inboundGateway)
        {
            _bookingRepository = bookingRepository;
            _inboundGateway = inboundGateway;
        }
        public async Task<Guid> Handle(BookAppointmentCommand request, CancellationToken cancellationToken)
        {
            var result= await _bookingRepository.CreateBookingAsync(request.Booking);
            await _inboundGateway.SendNotification($"Booking created successfully, {request.Booking.PatientName} ");
            return result;
        }
    }
}
