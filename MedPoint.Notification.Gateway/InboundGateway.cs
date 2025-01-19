using MedPoint.Notification.Sender;

namespace MedPoint.Notification.Gateway
{
    public class InboundGateway
    {
        private readonly INotificationSender _notificationSender;

        public InboundGateway(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public async Task SendNotification(string message)
        {
            await _notificationSender.SendNotificationAsync(message);
        }
    }
}
