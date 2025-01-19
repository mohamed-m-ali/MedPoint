namespace MedPoint.Bookings.Domain.Entities
{
    public record class Slot(Guid Id, DateTime Time, Guid DoctorId, string DoctorName, bool IsReserved, decimal cost);
}
