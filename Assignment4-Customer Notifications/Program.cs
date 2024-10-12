namespace Assignment4_Customer_Notifications;

internal class Program
{
    static void Main(string[] args)
    {
        INotification email = new EmailNotification();
        INotification sms = new SMSNotification();
        INotification push = new PushNotification();

        SendNotificatonAndMassage send = new SendNotificatonAndMassage();

        send.SendMassage(email, "Succussful Send Using Email");
        send.SendMassage(sms, "Succussful Send Using SMS");
        send.SendMassage(push, "Succussful Send Using Push");
    }
}

