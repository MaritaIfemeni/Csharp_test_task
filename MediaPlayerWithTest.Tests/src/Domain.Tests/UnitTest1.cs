namespace MediaPlayerWithTest.Tests;

/// <summary>
///  Practicing few test before starting the adssignment
/// </summary>
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        bool testing = true;
        Assert.True(testing);
    }

    [Fact]
    public void CompareCalculation()
    {
        var first = 4 + 4;
        var second = 5 + 5;
        //Assert.Equal(second, first);
        Assert.NotEqual(second, first);
    }

    [Theory]
    [InlineData(22, 22, 44)]
    [InlineData(12, 18, 30)]
    public void CompareSum(int a, int b, int c)
    {
        var sum = a + b;
        Assert.Equal(sum,c);
    }
}