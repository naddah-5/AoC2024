namespace AoC.Tests;

using AoC.Day02;

public class Day02Test
{
    [Fact]
    public void VerifyReading()
    {
        bool verbose = false;
        Day02 day = new Day02();
        day.Read("Day02TestInput.txt");
        if (verbose)
        {
            Console.WriteLine("entering day 2");
            foreach (var arr in day.Input)
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
    public void ComputePartOneTest()
    {
        bool output = false;
        if (!output)
        {
            return;
        }
        Day02 day = new Day02();
        day.Read("Day02TestInput.txt");
        Console.WriteLine("test data results:");
        foreach (var level in day.Input)
        {
            var safety = day.StrictDiff(level, 3);
            Console.WriteLine(safety);
        }
    }

    [Fact]
    public void ComputeDay02PartOne()
    {
        bool output = false;
        if (!output)
        {
            return;
        }
        var day = new Day02();
        day.Read("Day02Input.txt");
        var res = day.SafeLevels(3, false);
        Console.WriteLine("Day 02 Part One:\nThere are {0} safe levels", res);
    }

    [Fact]
    public void ComputeDay02PartTwoTest()
    {
        bool output = false;
        if (!output)
        {
            return;
        }
        var day = new Day02();
        day.Read("Day02TestInput.txt");
        var res = day.SafeLevels(3, true);
        Console.WriteLine("Day 02 Part Two Test:\nThere are {0} safe levels", res);
    }

    [Fact]
    public void ComputeDay02PartTwo()
    {
        bool output = true;
        if (!output)
        {
            return;
        }
        var day = new Day02();
        day.Read("Day02PartTwoInput.txt");
        var res = day.SafeLevels(3, true);
        Console.WriteLine("Day 02 Part Two:\nThere are {0} safe levels", res);
    }

    [Fact]
    public void TestStrictDiffRate0()
    {
        List<int> input = new List<int> { 0, 1, 2 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate1()
    {
        List<int> input = new List<int> { 20, 21, 23 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate2()
    {
        List<int> input = new List<int> { 10, 11, 13 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate3()
    {
        List<int> input = new List<int> { -2, 0, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate4()
    {
        List<int> input = new List<int> { 0, 3, 5 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate5()
    {
        List<int> input = new List<int> { 3, 4, 5 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate6()
    {
        List<int> input = new List<int> { 0, 1, 5 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate7()
    {
        List<int> input = new List<int> { 0, 4, 5 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate8()
    {
        List<int> input = new List<int> { 0, 2, 2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate9()
    {
        List<int> input = new List<int> { -2, 10, 2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate10()
    {
        List<int> input = new List<int> { 10, -11, 13 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate11()
    {
        List<int> input = new List<int> { 20, 21, 21 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate12()
    {
        List<int> input = new List<int> { 3, 2, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate13()
    {
        List<int> input = new List<int> { -1, -2, -3 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate14()
    {
        List<int> input = new List<int> { 5, 2, 0 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate15()
    {
        List<int> input = new List<int> { 3, 0, -1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate16()
    {
        List<int> input = new List<int> { 3, 2, -1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate17()
    {
        List<int> input = new List<int> { 3, 0, -3 };
        Day02 day = new Day02();
        Assert.True(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate18()
    {
        List<int> input = new List<int> { 3, -2, -1 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate19()
    {
        List<int> input = new List<int> { 5, 1, 0 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate20()
    {
        List<int> input = new List<int> { 3, -1, -2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate21()
    {
        List<int> input = new List<int> { 3, 2, -2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestStrictDiffRate22()
    {
        List<int> input = new List<int> { 4, 0, -4 };
        Day02 day = new Day02();
        Assert.False(day.StrictDiff(input, 3));
    }

    [Fact]
    public void TestOnInput0()
    {
        List<int> input = new List<int> { 7, 6, 4, 2, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDampDiff(input, 3));
    }

    [Fact]
    public void TestOnInput1()
    {
        List<int> input = new List<int> { 1, 2, 7, 8, 9 };
        Day02 day = new Day02();
        Assert.False(day.StrictDampDiff(input, 3));
    }

    [Fact]
    public void TestOnInput2()
    {
        List<int> input = new List<int> { 9, 7, 6, 2, 1 };
        Day02 day = new Day02();
        Assert.False(day.StrictDampDiff(input, 3));
    }

    [Fact]
    public void TestOnInput3()
    {
        List<int> input = new List<int> { 1, 3, 2, 4, 5 };
        Day02 day = new Day02();
        Assert.True(day.StrictDampDiff(input, 3));
    }


    [Fact]
    public void TestOnInput4()
    {
        List<int> input = new List<int> { 8, 6, 4, 4, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDampDiff(input, 3));
    }


    [Fact]
    public void TestOnInput5()
    {
        List<int> input = new List<int> { 1, 3, 6, 7, 9 };
        Day02 day = new Day02();
        Assert.True(day.StrictDampDiff(input, 3));
    }
}
