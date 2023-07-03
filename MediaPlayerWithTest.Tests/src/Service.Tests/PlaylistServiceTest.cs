using Moq;

using MediaPlayerWithTest.Business.src.Sevice;
using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;


namespace MediaPlayerWithTest.Tests.src.Service.Tests
{
    public class PlaylistServiceTest
    {
        [Fact]
        public void AddNewFile_Test()
        {
            var mockPlayListRepository = new Mock<IPlayListRepository>();
            var playListService = new PlayListService(mockPlayListRepository.Object);
            var playListId = 1;
            var mediaFileId = 1;
            var userId = 1;

            playListService.AddNewFile(playListId, mediaFileId, userId);
        
            mockPlayListRepository.Verify(x => x.AddNewFile(playListId, fileId, userId), Times.Once());
        }
    }
}