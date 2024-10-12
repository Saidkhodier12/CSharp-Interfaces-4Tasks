using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Media_Player_Plugins;
internal class Podcast : IMedia
{
    public void Play()
    {
        Console.WriteLine("Podcast Playing ... ");
    }

    public void Stop()
    {
        Console.WriteLine("Padcast Stopping ... ");
    }
}
