using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;

namespace MediaPlayerWithTest.Business.src.Sevice
{
    public class MediaService : IMediaService
    {
        private readonly IMediaRepository _mediaRepository;

        public MediaService(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository; 
        }

        public T CreateNewFile<T>(string fileName, string filePath, TimeSpan duration) where T : MediaFile
        {
            return _mediaRepository.CreateNewFile<T>(fileName, filePath, duration);
        }
      

        public bool DeleteFileById(int id)
        {
           return _mediaRepository.DeleteFileById(id);
        }

        public IEnumerable<MediaFile> GetAllFiles()
        {
            return _mediaRepository.GetAllFiles();
        }

        public MediaFile GetFileById(int id)
        {
           return _mediaRepository.GetFileById(id);
        }
    }
}