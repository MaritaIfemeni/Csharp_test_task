using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Domain.src.RepositoryInterface
{
    public interface IMediaRepository
    {
        void Play(int fileId);
        void Pause(int fileId);
        void Stop(int fileId);
        void CreateNewFile(string fileName, string filePath, TimeSpan duration);
        void DeleteFileById(int fileId);
        void GetAllFiles();
        void GetFileById(int fileId);
    }
}