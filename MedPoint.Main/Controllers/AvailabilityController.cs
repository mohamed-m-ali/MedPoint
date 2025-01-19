using MedPoint.Availability.BusinessLogic.Services;
using MedPoint.Availability.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MedPoint.Main.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvailabilityController : ControllerBase
    {
        private readonly AvailabilityService _doctorAvailabilityService;
        public AvailabilityController(AvailabilityService doctorAvailabilityService)
        {
            _doctorAvailabilityService = doctorAvailabilityService;
        }

        [HttpGet(Name = "GetAvailabilities")]
        public IEnumerable<Availabilty> Get()
        {
            return _doctorAvailabilityService.GetAvailabilities();
        }

        [HttpPost(Name = "AddAvailability")]
        public void Post(Availabilty doctorAvailability)
        {
            _doctorAvailabilityService.AddAvailability(doctorAvailability);
        }
    }
}
