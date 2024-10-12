using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Customer_Notifications;
internal class EmailNotification : INotification
{
    public void Send(string massage)
    {
        Console.WriteLine($"Send Email Massage : {massage}");
    }
}
