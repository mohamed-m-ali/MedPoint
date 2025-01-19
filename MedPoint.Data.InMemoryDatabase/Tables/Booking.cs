namespace MedPoint.Data.InMemoryDatabase.Tables
{
    public record Booking(
        Guid Id,
        Guid SlotId,
        Guid PatientId,
        string PatientName,
        DateTime ReservedAt);
}
