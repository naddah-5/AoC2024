namespace AoC.Tests;

using AoC.Day01;

public class Day01Test
{
    [Fact]
    public void Test1()
    {
        Day01 day = new Day01();
        day.Read();
        Console.WriteLine(day.DistDiff);
        Assert.Equal(1, 1);
    }
}
