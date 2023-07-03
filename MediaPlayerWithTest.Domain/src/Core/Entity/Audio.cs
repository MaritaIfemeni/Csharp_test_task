namespace MediaPlayerWithTest.Domain.src.Core.Entity
{
    public class Audio : MediaFile
    {
        public Audio(string fileName, string filePath, TimeSpan duration) : base(fileName, filePath, duration)
        {
        }
    }
}