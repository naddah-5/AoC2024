using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace AoC.Day01
{
    // No need to do all the extra stuff, we only need the diff between the 
    // sum of the right and left lists.
    public class Day01
    {
        public required int[][] _diffArr = new int[1000][];
        public required int[][] DiffArr
        {
            get
            {
                return this._diffArr;
            }
            set
            {
                _diffArr = value;
            }
        }
        private int _distDiff;
        public int DistDiff
        {
            get
            {
                return this._distDiff;
            }
            set
            {
                _distDiff = value;
            }
        }

        // Constructor
        [SetsRequiredMembers]
        public Day01()
        {
            this._diffArr = new int[1000][];
            DiffArr = new int[1000][];
            this._distDiff = 0;
            DistDiff = 0;
        }

        public void Read()
        {
            string fp = "day01Input.txt";
            using (FileStream fs = File.Open(fp, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int i = 0;
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    string p = temp.GetString(b);
                    int[] ps = p.Split(' ')
                        .Select(s => int.Parse(s))
                        .ToArray();
                    Console.WriteLine(ps);
                    try
                    {
                        this.DiffArr[i] = new int[] { ps[0], ps[1] };
                        Console.WriteLine(this.DiffArr[i]);
                        i++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("[WARNING] - received empty line");
                    }
                }
            }
        }

        public void CalcDiff()
        {
            string fp = "day01Input.txt";
            using (FileStream fs = File.Open(fp, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);

                int leftSum = 0;
                int rightSum = 0;
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    string p = temp.GetString(b);
                    string[] ps = p.Split(' ');
                    leftSum += Int32.Parse(ps[0]);
                    rightSum += Int32.Parse(ps[1]);
                }
                this.DistDiff = (Math.Abs(leftSum - rightSum));
            }
        }

    }
}
