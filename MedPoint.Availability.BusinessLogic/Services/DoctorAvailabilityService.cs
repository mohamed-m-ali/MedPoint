using MedPoint.Availability.DataAccess.Entities;
using MedPoint.Availability.DataAccess.Repositories;

namespace MedPoint.Availability.BusinessLogic.Services
{
    public class DoctorAvailabilityService
    {
        private readonly DoctorAvailabilityRepository _doctorAvailabilityRepository;
        public DoctorAvailabilityService(DoctorAvailabilityRepository doctorAvailabilityRepository)
        {
            _doctorAvailabilityRepository = doctorAvailabilityRepository;
        }

        public void AddDoctorAvailability(DoctorAvailabilty doctorAvailability)
        {
            _doctorAvailabilityRepository.AddDoctorAvailability(doctorAvailability);
        }

        public List<DoctorAvailabilty> GetDoctorAvailabilities()
        {
            return _doctorAvailabilityRepository.GetDoctorAvailabilities();
        }
    }
}
