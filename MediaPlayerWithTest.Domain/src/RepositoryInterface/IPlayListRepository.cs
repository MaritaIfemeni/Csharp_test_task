using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Domain.src.RepositoryInterface
{
    public interface IPlayListRepository
    {
        MediaFile AddNewFile(int playListId, int fileId, int userId);
        bool RemoveFile(int playListId, int fileId, int userId);
        bool EmptyList(int playListId, int userId);
    }
}