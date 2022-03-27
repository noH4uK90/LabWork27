namespace Task3
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVlc(String fileName)
        {
            //do nothing
        }
        public void PlayMp4(String fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }
    }
}
