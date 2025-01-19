
namespace MedPoint.Notification.Sender
{
    public class NotificationSender : INotificationSender
    {
        public async Task SendNotificationAsync(string message)
        {
            await Task.Delay(0);
            Console.WriteLine($"Sending notification: {message}");
        }
    }
}
