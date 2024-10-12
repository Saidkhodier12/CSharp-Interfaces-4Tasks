namespace Assignment1_Payment_Methods;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Amount To Paid : ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Choose Using Payment : ");
        Console.WriteLine("Enter : 1 , To Use Credit Card ");
        Console.WriteLine("Enter : 2 , To Use Bank Transfer ");
        Console.WriteLine("Enter : 3 , To Use PayPal ");


        int choicer = int.Parse(Console.ReadLine());

        switch (choicer)
        {
            case 1:
                CreditCardPayment C = new CreditCardPayment();
                C.ProcessPayment(amount);
                break;
            case 2:
                BankTransfer B = new BankTransfer();
                B.ProcessPayment(amount);
                break;
            case 3:
                PayPal P = new PayPal();
                P.ProcessPayment(amount);
                break;
            default:
                Console.WriteLine("No Choice Payment Method");
                break;
        }

    }
}
