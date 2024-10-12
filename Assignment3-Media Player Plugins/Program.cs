namespace Assignment3_Media_Player_Plugins;

internal class Program
{
    static void Main(string[] args)
    {
        IMedia audio = new Audio();
        IMedia video = new Video();
        IMedia podcast = new Podcast();
        IMedia liveStream = new LiveStream();

        MediaPlayer mediaPlayer = new MediaPlayer();

        mediaPlayer.PlayMedia(audio);
        mediaPlayer.StopMedia(audio);

        mediaPlayer.PlayMedia(video);
        mediaPlayer.StopMedia(video);

        mediaPlayer.PlayMedia(podcast);
        mediaPlayer.StopMedia(podcast);

        mediaPlayer.PlayMedia(liveStream);
        mediaPlayer.StopMedia(liveStream);


    }
}
