using MedPoint.Availability.DataAccess.Entities;

namespace MedPoint.Availability.DataAccess.Repositories
{
    public class DoctorAvailabilityRepository
    {
        private readonly List<DoctorAvailabilty> _doctorAvailabilities;
        public DoctorAvailabilityRepository()
        {
            _doctorAvailabilities = new List<DoctorAvailabilty>();
        }

        public void AddDoctorAvailability(DoctorAvailabilty doctorAvailability)
        {
            _doctorAvailabilities.Add(doctorAvailability);
        }

        public List<DoctorAvailabilty> GetDoctorAvailabilities()
        {
            return _doctorAvailabilities;
        }
    }
}
