using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;

namespace MediaPlayerWithTest.Infrastructure.src.Repository
{
    public class PlayListRepository : IPlayListRepository
    {
        private readonly Dictionary<int, List<int>> _playListDictionary = new();
        private readonly Dictionary<int, List<int>> _userPlaylistDictionary = new();
        private readonly IMediaRepository _mediaRepository;

        public PlayListRepository(IMediaRepository mediaRepository)
        {
            _playListDictionary = new();
            _userPlaylistDictionary = new();
            _mediaRepository = mediaRepository;
        }
        public MediaFile AddNewFile(int playListId, int fileId, int userId)
        {
            if (_playListDictionary.ContainsKey(playListId))
            {
                _playListDictionary[playListId].Add(fileId);
                return _mediaRepository.GetFileById(fileId);
            }
            else
            {
                _playListDictionary.Add(playListId, new List<int> { fileId });
                return _mediaRepository.GetFileById(fileId);
            }
        }
        public bool EmptyList(int playListId, int userId)
        {
            if (_playListDictionary.ContainsKey(playListId))
            {
                _playListDictionary[playListId].Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveFile(int playListId, int fileId, int userId)
        {
            if (_playListDictionary.ContainsKey(playListId))
            {
                _playListDictionary[playListId].Remove(fileId);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}