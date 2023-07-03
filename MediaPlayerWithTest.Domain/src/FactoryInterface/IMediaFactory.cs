using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Domain.src.FactoryInterface
{
    public interface IMediaFactory
    {
        MediaFile CreateMediaFile(string fileName, string filePath, TimeSpan duration, MediaType mediaType);
    }
    
}
