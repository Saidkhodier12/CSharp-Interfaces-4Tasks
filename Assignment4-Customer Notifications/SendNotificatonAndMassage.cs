using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Customer_Notifications;
internal class SendNotificatonAndMassage
{
    public void SendMassage(INotification notification , string massage)
    {
        notification.Send(massage);
    }
}
