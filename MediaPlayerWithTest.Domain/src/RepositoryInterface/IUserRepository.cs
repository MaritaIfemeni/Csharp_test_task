using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Domain.src.RepositoryInterface
{
    public interface IUserRepository
    {
        PlayList AddNewList(string name, int userId);
        bool RemoveOneList(int listId, int userId);
        bool RemoveAllLists(int userId);
        bool EmptyOneList(int listId, int userId);
        IEnumerable<PlayList> GetAllList(int userId);
        PlayList GetListById(int listId);
    }
}