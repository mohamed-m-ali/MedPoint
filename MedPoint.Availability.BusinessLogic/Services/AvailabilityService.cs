using MedPoint.Availability.DataAccess.Entities;
using MedPoint.Availability.DataAccess.Repositories;

namespace MedPoint.Availability.BusinessLogic.Services
{
    public class AvailabilityService
    {
        private readonly AvailabilityRepository _doctorAvailabilityRepository;
        public AvailabilityService(AvailabilityRepository doctorAvailabilityRepository)
        {
            _doctorAvailabilityRepository = doctorAvailabilityRepository;
        }

        public void AddAvailability(Availabilty doctorAvailability)
        {
            _doctorAvailabilityRepository.AddDoctorAvailability(doctorAvailability);
        }

        public List<Availabilty> GetAvailabilities()
        {
            return _doctorAvailabilityRepository.GetDoctorAvailabilities();
        }
    }
}
