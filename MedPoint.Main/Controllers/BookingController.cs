using MediatR;
using MedPoint.Bookings.Application.Bookings.Commands;
using MedPoint.Bookings.Application.Bookings.Queries;
using MedPoint.Bookings.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MedPoint.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slot>>> GetAvailableSlots()
        {
            return Ok( await _mediator.Send(new GetAvailableSlotsQuery()));
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> BookAppointment(Booking booking)
        {
            return await _mediator.Send(new BookAppointmentCommand(booking));
        }
    }
}
