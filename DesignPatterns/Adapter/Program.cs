using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adapter umożliwia na współprace dwóch klas o niekompatybilnych interfejsach.
            //W tym przykładzie SmsSender nie jest kompatybilny z interfejsem INotificationSender, dlatego tworzymy adapter, który implementuje ten interfejs i jednocześnie korzysta z klast SmsSender
            INotificationSender notificationSender = new EmailSender();
            notificationSender.SendNotification(1, new Notification { Title = "Tytuł", Body = "Ciało wiadomości" });

            INotificationSender notificationSender2 = new SmsSenderAdapter();
            notificationSender2.SendNotification(100, new Notification { Title = "Tytuł", Body = "Ciało wiadomości" });
        }
    }
}
