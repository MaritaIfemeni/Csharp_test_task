using Moq;

using MediaPlayerWithTest.Business.src.Sevice;
using MediaPlayerWithTest.Business.src.ServiceInterface;
using MediaPlayerWithTest.Domain.src.Core.Entity;
using MediaPlayerWithTest.Domain.src.RepositoryInterface;

namespace MediaPlayerWithTest.Tests.src.Service.Tests
{
    public class MediaServiceTest
    {
        [Fact]
        public void CreateNewFile_Test()
        {
            var mockMediaRepository = new Mock<IMediaRepository>();
            var mediaService = new MediaService(mockMediaRepository.Object);
            var fileName = "TestAudio";
            var filePath = "AUDIO";
            var duration = TimeSpan.FromSeconds(500);

            mediaService.CreateNewFile<Audio>(fileName, filePath, duration);

            mockMediaRepository.Verify(r => r.CreateNewFile<Audio>(fileName, filePath, duration), Times.Once);
        }
    }
}
