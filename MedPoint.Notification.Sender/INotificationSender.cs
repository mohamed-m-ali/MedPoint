namespace MedPoint.Notification.Sender
{
    public interface INotificationSender
    {
        Task SendNotificationAsync(string message);
    }
}
