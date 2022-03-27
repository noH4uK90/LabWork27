namespace Task3
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(String audioType)
        {

            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new VlcPlayer();

            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public void Play(String audioType, String fileName)
        {

            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}
