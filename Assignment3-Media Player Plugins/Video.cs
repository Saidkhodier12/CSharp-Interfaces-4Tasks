using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Media_Player_Plugins;
internal class Video : IMedia
{
    public void Play()
    {
        Console.WriteLine("Video Playing ... ");
    }

    public void Stop()
    {
        Console.WriteLine("Video Stopping ... ");
    }
}
