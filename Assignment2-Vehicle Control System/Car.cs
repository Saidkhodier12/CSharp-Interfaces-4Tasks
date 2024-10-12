using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Vehicle_Control_System;
internal class Car : IVechiles
{
    public void Descripe()
    {
        Console.WriteLine("A car is a vehicle designed for transporting people. It typically has four wheels and is powered by an internal combustion engine or an electric motor");
    }
    public void Start()
    {
        Console.WriteLine("Car Starting ... ");
    }

    public void Stop()
    {
        Console.WriteLine("Car Stoping ... ");
    }
}
