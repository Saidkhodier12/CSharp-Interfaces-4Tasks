using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Customer_Notifications;
internal class PushNotification : INotification
{
    public void Send(string massage)
    {
        Console.WriteLine($"Send Push Massage : {massage}");
    }
}
