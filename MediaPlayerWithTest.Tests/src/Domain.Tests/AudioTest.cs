using MediaPlayerWithTest.Domain.src.Core.Entity;

namespace MediaPlayerWithTest.Tests.src.Domain.Tests
{
    public class AudioTest
    {

        [Theory]
        [InlineData("name1", "path1", 300)]
        public void CreateAudioFile_Test(string fileName, string filePath, int duration)
        {
            var audio = new Audio(fileName, filePath, TimeSpan.FromSeconds(duration));
            
            Assert.Equal(fileName, audio.FileName);
            Assert.Equal(filePath, audio.FilePath);
            Assert.Equal(TimeSpan.FromSeconds(duration), audio.Duration);
        }
        public static IEnumerable<object[]> AudioData()
        {
            yield return new object[] {new Audio("name1", "path1", TimeSpan.FromSeconds(300))};
        }

        [Theory]
        [MemberData(nameof(AudioData))]
        public void CreateAudioFileWithId_Test(Audio audio)
        {
            Assert.Equal(0, audio.GetId);
        }

    }
}
