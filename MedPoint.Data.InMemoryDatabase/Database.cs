using MedPoint.Data.InMemoryDatabase.Tables;

namespace MedPoint.Data.InMemoryDatabase
{
    public class Database
    {
        public static List<Slot> Slots { get; set; } = new();
        public static List<Booking> Bookings { get; set; } = new();

    }
}
