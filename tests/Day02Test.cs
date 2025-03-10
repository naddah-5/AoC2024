namespace AoC.Tests;

using AoC.Day02;

public class Day02Test
{
    [Fact]
    public void VerifyReading()
    {
        bool verbose = false;
        Console.WriteLine("entering day 2");
        Day02 day = new Day02();
        day.Read("Day02TestInput.txt");
        if (verbose)
        {
            foreach (int[] arr in day.Input)
            {
                foreach (int data in arr)
                {
                    Console.Write(data);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }

    [Fact]
    public void TestStrictDiffRate0()
    {
        int[] input = { 0, 1, 2 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate1()
    {
        int[] input = { 20, 21, 23 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate2()
    {
        int[] input = { 10, 11, 13 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate3()
    {
        int[] input = { -2, 0, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate4()
    {
        int[] input = { 0, 3, 5 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate5()
    {
        int[] input = { 3, 4, 5 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate6()
    {
        int[] input = { 0, 1, 5 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate7()
    {
        int[] input = { 0, 4, 5 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate8()
    {
        int[] input = { 0, 2, 2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate9()
    {
        int[] input = { -2, 10, 2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate10()
    {
        int[] input = { 10, -11, 13 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate11()
    {
        int[] input = { 20, 21, 21 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate12()
    {
        int[] input = { 3, 2, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate13()
    {
        int[] input = { -1, -2, -3 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate14()
    {
        int[] input = { 5, 2, 0 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate15()
    {
        int[] input = { 3, 0, -1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate16()
    {
        int[] input = { 3, 2, -1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate17()
    {
        int[] input = { 3, 0, -3 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate18()
    {
        int[] input = { 3, -2, -1 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate19()
    {
        int[] input = { 5, 1, 0 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate20()
    {
        int[] input = { 3, -1, -2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate21()
    {
        int[] input = { 3, 2, -2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate22()
    {
        int[] input = { 4, 0, -4 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }
}


