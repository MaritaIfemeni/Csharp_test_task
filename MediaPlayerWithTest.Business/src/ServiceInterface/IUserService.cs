using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Business.src.ServiceInterface
{
    public interface IUserService
    {
        PlayList AddNewList(string name, int userId);
        bool RemoveOneList(int listId, int userId);
        bool RemoveAllLists(int userId);
        bool EmptyOneList(int listId, int userId);
        IEnumerable<PlayList> GetAllList(int userId);
        PlayList GetListById(int listId);
    }
}