namespace AoC.Tests;

using AoC.Day01;

public class Day01Test
{
    [Fact]
    public void TestPartOne()
    {
        Day01 day = new Day01();
        day.Read("testInput.txt");
        int[] left = day.LeftList.ToArray();
        int[] right = day.RightList.ToArray();
        for (int i = 0; i < day.RightList.Count; i++) 
        {
            Console.WriteLine(left[i].ToString() + "   " + right[i].ToString());
        }
        var res = day.CalcPostion();
        Assert.Equal(11, res);
    }

    [Fact]
    public void ActualInputPartOne() 
    {
        Day01 day = new Day01();
        day.Read("day01Input.txt");
        int res = day.CalcPostion();
        Console.WriteLine("position: " + res.ToString());
        Assert.True(true);
    }
    
    [Fact]
    public void TestPartTwo() 
    {
        Day01 day = new Day01();
        day.Read("testInput.txt");
        int res = day.SimilarityScore();
        Console.WriteLine("test similarity score: " + res.ToString());
        Assert.True(true);
    }

    [Fact]
    public void ActualInputPartTwo() 
    {
        Day01 day = new Day01();
        day.Read("day01Input.txt");
        int res = day.SimilarityScore();
        Console.WriteLine("similarity score: " + res.ToString());
        Assert.True(true);
    }
}
