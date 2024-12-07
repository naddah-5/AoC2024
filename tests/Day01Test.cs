namespace AoC.Tests;

using AoC.Day01;

public class Day01Test
{
    [Fact]
    public void Test1()
    {
        var day = new Day01();
        var res = day.NewMethod(true);
        Assert.True(res);
    }
}
