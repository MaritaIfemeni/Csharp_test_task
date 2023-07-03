using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Application.src
{
    public class PlayListController
    {
        private readonly IPlayListService _playListService;

        public PlayListController(IPlayListService playListService)
        {
            _playListService = playListService;
        }

        public MediaFile AddNewFile(int playListId, int fileId, int userId)
        {
            return _playListService.AddNewFile(playListId, fileId, userId);
        }

        public bool EmptyList(int playListId, int userId)
        {
           return _playListService.EmptyList(playListId, userId);
        }

        public bool RemoveFile(int playListId, int fileId, int userId)
        {
            return _playListService.RemoveFile(playListId, fileId, userId);
        }
    }
}