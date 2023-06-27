using System.Security.AccessControl;
using MediaPlayerWithTest.Domain.src.Core;

namespace MediaPlayerWithTest.Tests.src.Domain.Tests
{
    public class AudioTest
    {
        [Theory]
        [InlineData("name1", "path1", 300)]
        [InlineData("name2", "path2", 400)]

        public void CreateAudioFile(string fileName, string filePath, int duration)
        {
            var audio = new Audio(fileName, filePath, TimeSpan.FromSeconds(duration));
            Assert.Equal(fileName, audio.FileName);
            Assert.Equal(filePath, audio.FilePath);
            Assert.Equal(TimeSpan.FromSeconds(duration), audio.Duration);
        }

        [Fact]
        public void CreateAudioFileWithId()
        {
            var audio1 = new Audio("name1", "path1", TimeSpan.FromSeconds(300));
            var audio2 = new Audio("name2", "path2", TimeSpan.FromSeconds(400));
            var audio3 = new Audio("name3", "path3", TimeSpan.FromSeconds(500));
            Assert.Equal(0, audio1.GetId);
            Assert.Equal(1, audio2.GetId);
            Assert.Equal(2, audio3.GetId);
        }
    }
}