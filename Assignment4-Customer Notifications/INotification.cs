using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Customer_Notifications;
internal interface INotification
{
    void Send(string massage);
}
