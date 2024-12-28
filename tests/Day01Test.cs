namespace AoC.Tests;

using AoC.Day01;

public class Day01Test
{
    [Fact]
    public void TestPartOne()
    {
        bool print = false;
        Day01 day = new Day01();
        day.Read("testInput.txt");
        int[] left = day.LeftList.ToArray();
        int[] right = day.RightList.ToArray();
        if (print)
        {
            for (int i = 0; i < day.RightList.Count; i++)
            {
                Console.WriteLine(left[i].ToString() + "   " + right[i].ToString());
            }
        }
        var res = day.CalcPostion();
        Assert.Equal(11, res);
    }

    [Fact]
    public void ActualInputPartOne()
    {
        bool print = false;
        Day01 day = new Day01();
        day.Read("day01Input.txt");
        int res = day.CalcPostion();
        if (print)
        {
            Console.WriteLine("position: " + res.ToString());
        }
        Assert.True(true);
    }
    [Fact]
    public void TestPartTwo()
    {
        bool print = false;
        Day01 day = new Day01();
        day.Read("testInput.txt");
        int res = day.SimilarityScore();
        if (print)
        {
            Console.WriteLine("test similarity score: " + res.ToString());
        }
        Assert.True(true);
    }

    [Fact]
    public void ActualInputPartTwo()
    {
        bool print = false;
        Day01 day = new Day01();
        day.Read("day01Input.txt");
        int res = day.SimilarityScore();
        if (print)
        {
            Console.WriteLine("similarity score: " + res.ToString());
        }
        Assert.True(true);
    }
}
