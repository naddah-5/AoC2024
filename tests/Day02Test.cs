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
    public void TestStrictIncValid0()
    {
        int[] input = { 0, 1, 2 };
        Day02 day = new Day02();
        Assert.True(day.StrictInc(input, 3));
    }


    [Fact]
    public void TestStrictIncValid1()
    {
        int[] input = { 20, 21, 23 };
        Day02 day = new Day02();
        Assert.True(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncValid2()
    {
        int[] input = { 10, 11, 13 };
        Day02 day = new Day02();
        Assert.True(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncValid3()
    {
        int[] input = { -2, 0, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncValid4()
    {
        int[] input = { 0, 3, 5 };
        Day02 day = new Day02();
        Assert.True(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncValid5()
    {
        int[] input = { 3, 4, 5 };
        Day02 day = new Day02();
        Assert.True(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncInvalid0()
    {
        int[] input = { 0, 1, 5 };
        Day02 day = new Day02();
        Assert.False(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncInvalid1()
    {
        int[] input = { 0, 4, 5 };
        Day02 day = new Day02();
        Assert.False(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncInvalid2()
    {
        int[] input = { 0, 2, 2 };
        Day02 day = new Day02();
        Assert.False(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncInvalid3()
    {
        int[] input = { -2, 10, 2 };
        Day02 day = new Day02();
        Assert.False(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictIncInvalid4()
    {
        int[] input = { 10, -11, 13 };
        Day02 day = new Day02();
        Assert.False(day.StrictInc(input, 3));

    }

    [Fact]
    public void TestStrictIncInvalid5()
    {
        int[] input = { 20, 21, 21 };
        Day02 day = new Day02();
        Assert.False(day.StrictInc(input, 3));
    }

    [Fact]
    public void TestStrictDecValid0()
    {
        int[] input = { 3, 2, 1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecValid1()
    {
        int[] input = { -1, -2, -3 };
        Day02 day = new Day02();
        Assert.True(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecValid2()
    {
        int[] input = { 5, 2, 0 };
        Day02 day = new Day02();
        Assert.True(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecValid3()
    {
        int[] input = { 3, 0, -1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecValid4()
    {
        int[] input = { 3, 2, -1 };
        Day02 day = new Day02();
        Assert.True(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecValid5()
    {
        int[] input = { 3, 0, -3 };
        Day02 day = new Day02();
        Assert.True(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecInvalid0()
    {
        int[] input = { 1, 2, 3 };
        Day02 day = new Day02();
        Assert.False(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecInvalid1()
    {
        int[] input = { 3, -2, -1 };
        Day02 day = new Day02();
        Assert.False(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecInvalid2()
    {
        int[] input = { 5, 1, 0 };
        Day02 day = new Day02();
        Assert.False(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecInvalid3()
    {
        int[] input = { 3, -1, -2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecInvalid4()
    {
        int[] input = { 3, 2, -2 };
        Day02 day = new Day02();
        Assert.False(day.StrictDec(input, 3));
    }

    [Fact]
    public void TestStrictDecInvalid5()
    {
        int[] input = { 4, 0, -4 };
        Day02 day = new Day02();
        Assert.False(day.StrictDec(input, 3));
    }

}


