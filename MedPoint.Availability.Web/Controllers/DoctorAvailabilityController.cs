using MedPoint.Availability.BusinessLogic.Services;
using MedPoint.Availability.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MedPoint.Availability.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorAvailabilityController : ControllerBase
    {
        private readonly DoctorAvailabilityService _doctorAvailabilityService;
        public DoctorAvailabilityController(DoctorAvailabilityService doctorAvailabilityService)
        {
            _doctorAvailabilityService = doctorAvailabilityService;
        }

        [HttpGet(Name = "GetDoctorAvailabilities")]
        public IEnumerable<DoctorAvailabilty> Get()
        {
            return _doctorAvailabilityService.GetDoctorAvailabilities();
        }

        [HttpPost(Name = "AddDoctorAvailability")]
        public void Post(DoctorAvailabilty doctorAvailability)
        {
            _doctorAvailabilityService.AddDoctorAvailability(doctorAvailability);
        }
    }
}
