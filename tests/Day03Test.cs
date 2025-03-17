namespace AoC.Tests;

using AoC.Day03;

public class Day03Test
{
    [Fact]
    public void TestDay03CalcPartTwo()
    {
        bool skip = false;
        if (skip)
        {
            return;
        }
        Day03 d = new Day03(true);
        d.Read("inputData/Day03Input.txt");
        d.Parse();
        var res = d.Calc();
        Console.WriteLine(res);
    }
    [Fact]
    public void TestDay03FilterMul0()
    {
        string input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";
        Day03 d = new Day03(true);
        d.Input.Add(d.FilterMul(input));
        d.Parse();
        var res = d.Calc();
        Console.WriteLine(res);
    }

    [Fact]
    public void TestDay03FilterMul1()
    {
        Day03 d = new Day03(true);
        d.Read("inputData/Day03TestInputTwo.txt");
        d.Parse();
        var res = d.Calc();
        Assert.Equal(48, res);
    }

    [Fact]
    public void TestDay03FilterMul2()
    {
        Day03 d = new Day03(true);
        d.Read("inputData/Day03Custom2.txt");
        d.Parse();
        var res = d.Calc();
        Assert.Equal(10, res);
    }

    [Fact]
    public void TestDay03CalcInput()
    {
        bool skip = true;
        if (skip)
        {
            return;
        }
        Day03 day = new Day03(false);
        day.Read("inputData/Day03Input.txt");
        List<int> expected = new List<int>();
        expected.AddRange(new int[] { 8, 25, 88, 40 });

        day.Parse();
        int res = day.Calc();
        Console.WriteLine(res);

    }

    [Fact]
    public void TestDay03CalcTestInput()
    {
        Day03 day = new Day03(false);
        day.Read("inputData/Day03TestInput.txt");
        List<int> expected = new List<int>();
        expected.AddRange(new int[] { 8, 25, 88, 40 });

        day.Parse();
        int res = day.Calc();
        Assert.Equal(161, res);
    }


    [Fact]
    public void TestDay03Formating()
    {
        Day03 day = new Day03(false);
        day.Read("inputData/Day03TestInput.txt");
        List<int[]> expected = new List<int[]>();
        expected.Add(new int[] { 2, 4 });
        expected.Add(new int[] { 5, 5 });
        expected.Add(new int[] { 11, 8 });
        expected.Add(new int[] { 8, 5 });

        day.Parse();

        Assert.Equal(expected, day.Parsed);
    }

    [Fact]
    public void TestDay03MulParse()
    {
        bool verbose = false;
        string input = "9u0jmul(120,20)dfhjlkmul(13,0)skmul(1das3,xx0)ndmul(120mul(12,2),20)lmul(10,20,30)aommul(1, 2, 4)ul[1,2]dasd";
        Day03 day = new Day03(false);
        var res = day.MulParse(input);
        if (verbose)
        {
            foreach (var operands in day.Parsed)
            {
                Console.WriteLine("parsed multipication:");
                foreach (var item in operands)
                {
                    Console.WriteLine(item);
                }
            }
        }
        Assert.Equal(6, res.Count());
    }

    [Fact]
    public void TestDay03OperandParse0()
    {
        bool verbose = false;
        string[] input = { "123", "5" };
        int[] expected = { 123, 5 };
        Day03 day = new Day03(false);
        var res = day.OperandParse(input);
        if (verbose)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        Assert.Equal(expected, res);
    }

    [Fact]
    public void TestDay03OperandParse1()
    {
        bool verbose = false;
        string[] input = { "123", "3", "4" };
        int[] expected = { 123, 3, 4 };
        Day03 day = new Day03(false);
        var res = day.OperandParse(input);
        if (verbose)
        {
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        Assert.Equal(expected, res);
    }

    [Fact]
    public void TestDay03OperandParse2()
    {
        string[] input = { "123", "3dsa", "4" };
        Day03 day = new Day03(false);
        Assert.Throws<FormatException>(() => day.OperandParse(input));
    }

    [Fact]
    public void TestDay03OperandParse3()
    {
        string[] input = { "123", "3", " 4" };
        Day03 day = new Day03(false);
        Assert.Throws<FormatException>(() => day.OperandParse(input));
    }

    [Fact]
    public void TestDay03OperandParse4()
    {
        string[] input = { " ", "3", "4" };
        Day03 day = new Day03(false);
        Assert.Throws<FormatException>(() => day.OperandParse(input));
    }

    [Fact]
    public void TestDay03OperandParse5()
    {
        string[] input = { "123", "10 ", "4" };
        Day03 day = new Day03(false);
        Assert.Throws<FormatException>(() => day.OperandParse(input));
    }

}
