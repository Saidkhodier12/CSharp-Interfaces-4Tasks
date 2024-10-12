using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Media_Player_Plugins;
internal class MediaPlayer
{
    public void PlayMedia(IMedia media)
    {
        media.Play();
    }
    public void StopMedia(IMedia media)
    {
        media.Stop();
    }
}
