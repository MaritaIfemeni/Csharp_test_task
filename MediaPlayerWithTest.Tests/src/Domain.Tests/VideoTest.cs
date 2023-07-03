using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Tests.src.Domain.Tests
{
    public class VideoTest
    {
        [Fact]
        public void CreateVideoFile_Test()
        {
            string fileName = "name1";
            string filePath = "path1";
            int duration = 300;

            var video = new Video(fileName, filePath, TimeSpan.FromSeconds(duration));
            
            Assert.Equal(fileName, video.FileName);
            Assert.Equal(filePath, video.FilePath);
            Assert.Equal(duration, video.Duration);
        }
    }
}