using MedPoint.Availability.DataAccess.Entities;

namespace MedPoint.Availability.DataAccess.Repositories
{
    public class AvailabilityRepository
    {
        private readonly List<Availabilty> _doctorAvailabilities;
        public AvailabilityRepository()
        {
            _doctorAvailabilities = new List<Availabilty>();
        }

        public void AddDoctorAvailability(Availabilty doctorAvailability)
        {
            _doctorAvailabilities.Add(doctorAvailability);
        }

        public List<Availabilty> GetDoctorAvailabilities()
        {
            return _doctorAvailabilities;
        }
    }
}
