using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Application.src
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public PlayList AddNewList(string name, int userId)
        {
            return _userService.AddNewList(name, userId);
        }

        public bool EmptyOneList(int listId, int userId)
        {
            return _userService.EmptyOneList(listId, userId);
        }

        public IEnumerable<PlayList> GetAllList(int userId)
        {
            return _userService.GetAllList(userId);
        }

        public PlayList GetListById(int listId)
        {
            return _userService.GetListById(listId);
        }

        public bool RemoveAllLists(int userId)
        {
            return _userService.RemoveAllLists(userId);
        }

        public bool RemoveOneList(int listId, int userId)
        {
            return _userService.RemoveOneList(listId, userId);
        }
    }
}