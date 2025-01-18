namespace MedPoint.Availability.DataAccess.Entities
{
    public class DoctorAvailabilty
    {
        public Guid Id { get; set; }
        public DateTime Time  { get; set; }
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }
    }
}
