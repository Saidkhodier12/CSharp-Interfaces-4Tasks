using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Vehicle_Control_System;
internal class Truck : IVechiles
{
    public void Descripe()
    {
        Console.WriteLine("A truck is a vehicle designed primarily for transporting goods. It typically has more wheels than a car, often six or more, to handle heavier loads. Trucks are built for strength and durability, making them ideal for carrying large or heavy items over long distances. They are commonly used in industries such as logistics, construction, and agriculture.");
    }

    public void Start()
    {
        Console.WriteLine("Truck Starting ... ");
    }

    public void Stop()
    {
        Console.WriteLine("Truck Stoping ... ");
    }
}
