using MedPoint.Availability.DataAccess.Entities;
using MedPoint.Data.InMemoryDatabase;
using MedPoint.Data.InMemoryDatabase.Tables;

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
            Database.Slots.Add(new Slot(
                doctorAvailability.Id,
                doctorAvailability.Time,
                doctorAvailability.DoctorId,
                doctorAvailability.DoctorName,
                doctorAvailability.IsReserved,
                doctorAvailability.Cost));

        }

        public List<Availabilty> GetDoctorAvailabilities()
        {
            return Database.Slots.Select(s => new Availabilty(s.Id,
                s.Time,
                s.DoctorId,
                s.DoctorName,
                s.IsReserved,
                s.Cost)).ToList();
        }
    }
}
