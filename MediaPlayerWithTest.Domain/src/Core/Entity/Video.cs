namespace MediaPlayerWithTest.Domain.src.Core.Entity
{
    public class Video : MediaFile
    {
        public Video(string fileName, string filePath, TimeSpan duration) : base(fileName, filePath, duration)
        {
        }
    }
}