using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Vehicle_Control_System;
internal class Motorcycle : IVechiles
{
    public void Descripe()
    {
        Console.WriteLine("A motorcycle is a two-wheeled vehicle designed for quick and personal transportation. It is powered by an internal combustion engine or an electric motor and is known for its ability to easily maneuver through tight spaces and busy roads. Motorcycles are commonly used for both short and long-distance travel and are popular among speed enthusiasts and adventure seekers.");
    }

    public void Start()
    {
        Console.WriteLine("Motorcycle Starting ... ");
    }

    public void Stop()
    {
        Console.WriteLine("Motorcycle Stoping ... ");
    }
}
