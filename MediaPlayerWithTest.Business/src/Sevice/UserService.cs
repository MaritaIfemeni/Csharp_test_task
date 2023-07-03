using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;

namespace MediaPlayerWithTest.Business.src.Sevice
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public PlayList AddNewList(string name, int userId)
        {
           return _userRepository.AddNewList(name, userId);
        }

        public bool EmptyOneList(int listId, int userId)
        {
            return _userRepository.EmptyOneList(listId, userId);
        }

        public IEnumerable<PlayList> GetAllList(int userId)
        {
            return _userRepository.GetAllList(userId);
        }

        public PlayList GetListById(int listId)
        {
           return  _userRepository.GetListById(listId);
        }

        public bool RemoveAllLists(int userId)
        {
            return _userRepository.RemoveAllLists(userId);
        }

        public bool RemoveOneList(int listId, int userId)
        {
            return _userRepository.RemoveOneList(listId, userId);
        }
    }
}