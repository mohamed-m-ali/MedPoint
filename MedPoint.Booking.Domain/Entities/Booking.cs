namespace MedPoint.Bookings.Domain.Entities
{
    public record Booking(Guid Id, Guid SlotId, Guid PatientId, string PatientName, DateTime ReservedAt);
}
