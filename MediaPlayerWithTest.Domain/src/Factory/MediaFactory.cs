using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Domain.src.FactoryInterface;




namespace MediaPlayerWithTest.Domain.src.Factory
{
    public class MediaFactory : IMediaFactory
    {
        public MediaFile CreateMediaFile(string fileName, string filePath, TimeSpan duration, MediaType mediaType)
        {
            return mediaType switch
            {
                MediaType.Audio => new Audio(fileName, filePath, duration),
                MediaType.Video => new Video(fileName, filePath, duration),
                _ => throw new ArgumentException("Invalid media type"),
            };
        }
    }
}