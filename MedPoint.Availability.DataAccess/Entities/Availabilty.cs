namespace MedPoint.Availability.DataAccess.Entities
{
    public record Availabilty(Guid Id, DateTime Time, Guid DoctorId, string DoctorName, bool IsReserved, decimal Cost);
}
