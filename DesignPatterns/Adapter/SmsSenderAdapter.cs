using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender = new SmsSender();
        public void SendNotification(int userId, Notification notification)
        {
            string userNumberPhone = userId.ToString();// ten numer telefonu trzeb awyciągnąć na podstawie userId
            _smsSender.SendSms(userNumberPhone, $"Title: {notification.Title}\nBody: {notification.Body}");
        }
    }
}
