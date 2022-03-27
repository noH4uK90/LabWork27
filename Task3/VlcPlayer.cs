namespace Task3
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc(String fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
        public void PlayMp4(String fileName)
        {
            //do nothing
        }
    }
}
