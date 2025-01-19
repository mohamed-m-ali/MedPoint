namespace MedPoint.Appointments.Core.Entities
{
    public record Appointment(Guid Id, Guid SlotId, Guid PatientId, string PatientName, DateTime ReservedAt);
}
