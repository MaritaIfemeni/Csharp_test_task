using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;
using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Business.src.Sevice
{
    public class PlayListService : IPlayListService
    {
        private readonly IPlayListRepository _playList;

        public PlayListService(IPlayListRepository playList)
        {
            _playList = playList;
        }
        public MediaFile AddNewFile(int playListId, int fileId, int userId)
        {
            return _playList.AddNewFile(playListId, fileId, userId);
        }

        public bool EmptyList(int playListId, int userId)
        {
           return _playList.EmptyList(playListId, userId);
        }

        public bool RemoveFile(int playListId, int fileId, int userId)
        {
           return _playList.RemoveFile(playListId, fileId, userId);
        }
    }
}