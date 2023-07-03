using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;

namespace MediaPlayerWithTest.Infrastructure.src.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Dictionary<int, List<PlayList>> _playLists;
        public UserRepository()
        {
            _playLists = new();
        }

        public PlayList AddNewList(string name, int userId)
        {

            var playList = new PlayList(name, userId);
            var playLists = _playLists.FirstOrDefault(x => x.Key == userId).Value;
            if (playLists != null)
            {
                playLists.Add(playList);
            }
            else
            {
                _playLists.Add(userId, new List<PlayList> { playList });
            }
            return playList;

        }

        public bool EmptyOneList(int listId, int userId)
        {
            if (_playLists.TryGetValue(userId, out var playLists))
            {
                var emptyPlaylist = playLists.FirstOrDefault(x => x.GetId == listId);
                if (emptyPlaylist != null)
                {
                    emptyPlaylist.EmptyList(userId);
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<PlayList> GetAllList(int userId)
        {
            if (_playLists.TryGetValue(userId, out var playLists))
            {
                return playLists;
            }
            return null;
        }

        public PlayList GetListById(int listId)
        {
            var playLists = _playLists.FirstOrDefault(x => x.Value.Any(y => y.GetId == listId)).Value;
            if (playLists != null)
            {
                return playLists.FirstOrDefault(x => x.GetId == listId);
            }
            return null;

        }

        public bool RemoveAllLists(int userId)
        {
                var removePlaylist = _playLists.FirstOrDefault(x => x.Key == userId).Value;
                if (removePlaylist != null)
                {
                    removePlaylist.Clear();
                    return true;
                }
            return false;

        }

        public bool RemoveOneList(int listId, int userId)
        {
            var removePlaylist = _playLists.FirstOrDefault(x => x.Key == userId).Value;
            if (removePlaylist != null)
            {
                var removeList = removePlaylist.FirstOrDefault(x => x.GetId == listId);
                if (removeList != null)
                {
                    removePlaylist.Remove(removeList);
                    return true;
                }
            }
            return false;
        }
    }
}