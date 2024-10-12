namespace Assignment2_Vehicle_Control_System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choice Kind Of Vichele ? ");
        Console.WriteLine("Enter 1 , To Use Car ");
        Console.WriteLine("Enter 2 , To Use Truck ");
        Console.WriteLine("Enter 3 , To Use Motorcycle ");
        int choicer = int.Parse(Console.ReadLine());


        IVechiles vechile = null;

        switch (choicer)
        {
            case 1:
                vechile = new Car();
                break;
            case 2:
                vechile = new Truck();
                break;
            case 3:
                vechile = new Motorcycle();
                break;
            default:
                Console.WriteLine("Invalid Vechile");
                break;
        }

        vechile.Start();
        vechile.Stop();
        vechile.Descripe();
    }
}
