namespace AoC.Day02
{
    // Part one: how many lines are strictly increasing or decreasing. 
    // Min 1 max 3.
    public class Day02
    {
        private List<int[]> _input;
        public List<int[]> Input { get; set; }
        public Day02()
        {
            _input = new List<int[]>();
            Input = _input;
        }

        public void Read(string file)
        {
            string[] input = [.. File.ReadLines(file)];
            foreach (var line in input)
            {
                int[] Items = [.. line.Split(' ').Select(int.Parse)];
                this.Input.Add(Items);
            }
        }

        // Returns true if an array is strictly increasing or decrasing with at most 'max' difference.
        public bool StrictDiff(int[] arr, int max)
        {


            return true;
        }

        public bool StrictInc(int[] arr, int max)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool increasing = arr[i] > arr[i + 1];
                bool incLimit = Math.Abs(arr[i] - arr[i + 1]) > 3;
                bool same = arr[i] == arr[i + 1];
                if (increasing || incLimit || same)
                {
                    return false;
                }
            }
            return true;
        }

        public bool StrictDec(int[] arr, int max)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool increasing = arr[i] < arr[i + 1];
                bool incLimit = Math.Abs(arr[i] - arr[i + 1]) > 3;
                bool same = arr[i] == arr[i + 1];
                if (increasing || incLimit || same)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
