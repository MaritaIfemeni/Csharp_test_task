using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;


namespace MediaPlayerWithTest.Infrastructure.src.Repository
{
    public class MediaRepository : IMediaRepository
    {
        private readonly List<MediaFile> _mediaFiles = new();
        private static MediaRepository _instance;
        private static readonly Lazy<MediaRepository> _lazy = new(() => new MediaRepository());

        public static MediaRepository Instance => _lazy.Value;

        public T CreateNewFile<T>(string fileName, string filePath, TimeSpan duration) where T : MediaFile
        {
            var mediaFile = (T)Activator.CreateInstance(typeof(T), fileName, filePath, duration);
            _mediaFiles.Add(mediaFile);
            return mediaFile;
        }

        public bool DeleteFileById(int fileId)
        {
            MediaFile mediaFile = GetFileById(fileId);
            if (mediaFile != null)
            {
                _mediaFiles.Remove(mediaFile);
            }
            return false;
        }

        public IEnumerable<MediaFile> GetAllFiles()
        {
            return _mediaFiles;
        }

        public MediaFile GetFileById(int fileId)
        {
            return _mediaFiles.FirstOrDefault(mediaFile => mediaFile.GetId == fileId) ?? throw new ArgumentException("File was not found");
        }

        public void Pause(int fileId)
        {
            MediaFile mediaFile = GetFileById(fileId);
            mediaFile.Pause();
        }

        public void Play(int fileId)
        {
            MediaFile mediaFile = GetFileById(fileId);
            mediaFile.Play();
        }

        public void Stop(int fileId)
        {
            MediaFile mediaFile = GetFileById(fileId);
            mediaFile.Stop();
        }
    }
}