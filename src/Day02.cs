namespace AoC.Day02
{
    // Part one: how many lines are strictly increasing or decreasing. 
    // Min 1 max 3.
    public class Day02
    {
        private int _safetyMargin;
        public int SafetyMargin { get; set; }
        private List<int[]> _input;
        public List<int[]> Input { get; set; }
        public Day02()
        {
            _safetyMargin = 1;
            SafetyMargin = _safetyMargin;
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

        public bool StrictDampDiff(int[] input, int maxDiff)
        {
            if (input.Length < 3)
            {
                return false;
            }
            bool direction0 = input[0] - input[1] < 0;
            bool direction1 = input[1] - input[2] < 0;
            bool direction2 = input[2] - input[3] < 0;

            bool direction = (direction0 && direction1) || (direction0 && direction2);

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
                    this.SafetyMargin--;
                    if (this.SafetyMargin <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        var reduced = this.ReduceInput(input, i, input.Length - 1);
                        Console.WriteLine(reduced);
                        this.StrictDampDiff(reduced, maxDiff);
                    }
                }

            }
            return true;

        }

        public int[] ReduceInput(int[] input, int removeIndex, int length)
        {
            var reducedMargin = new int[length];
            for (int i = 0; i < input.Length; i++)
            {
                if (i == removeIndex)
                {
                    continue;
                }
                else if (i > removeIndex)
                {
                    reducedMargin[i - 1] = input[i];
                }
                else if (i < removeIndex)
                {
                    reducedMargin[i] = input[i];
                }
            }
            return reducedMargin;
        }

        public int SafeLevels(int maxDiff, bool dampener)
        {
            int safeLevels = 0;
            foreach (int[] level in this.Input)
            {
                bool safe;
                if (dampener)
                {
                    safe = this.StrictDampDiff(level, maxDiff);
                }
                else
                {
                    safe = this.StrictDiff(level, maxDiff);
                }
                if (safe)
                {
                    safeLevels++;
                }
            }
            return safeLevels;
        }
    }


}
