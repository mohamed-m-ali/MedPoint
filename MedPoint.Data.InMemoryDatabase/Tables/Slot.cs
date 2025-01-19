namespace MedPoint.Data.InMemoryDatabase.Tables
{
    public record Slot(
        Guid Id,
        DateTime Time,
        Guid DoctorId,
        string DoctorName,
        bool IsReserved,
        decimal Cost);
}
