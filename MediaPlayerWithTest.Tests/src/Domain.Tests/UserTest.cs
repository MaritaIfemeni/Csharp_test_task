using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Business.src.Sevice;

namespace MediaPlayerWithTest.Tests.src.Domain.Tests
{
    public class UserTest
    {
        [Fact]
        public void AddNewList_Test()
        {
            var user = User.Instance;
            var list = new PlayList("list1", 1);

            user.AddNewList(list);
            
            Assert.Contains(list, user.GetAllLists());
        }
    }
}