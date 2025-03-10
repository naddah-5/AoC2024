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
        public bool StrictDiff(int[] input, int maxDiff)
        {
            if (input.Length < 2)
            {
                return false;
            }
            bool direction = input[0] - input[1] < 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                // Check for the two safety requirements:
                // Strictly increasing or decreasing, checked by strict and neq.
                bool strict = (input[i] - input[i + 1] < 0) != direction;
                bool neq = input[i] == input[i + 1];
                // Difference limit, checked by diffLimit.
                bool diffLimit = Math.Abs(input[i] - input[i + 1]) > maxDiff;
                if (strict || diffLimit || neq)
                {
                    return false;
                }

            }
            return true;
        }
    }


}
