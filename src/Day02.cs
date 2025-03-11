namespace AoC.Day02
{
    // Part one: how many lines are strictly increasing or decreasing. 
    // Min 1 max 3.
    public class Day02
    {
        private int _safetyMargin;
        public int SafetyMargin { get; set; }
        private int _currentMargin;
        public int CurrentMargin { get; set; }
        private List<List<int>> _input;
        public List<List<int>> Input { get; set; }
        public Day02()
        {
            _safetyMargin = 1;
            SafetyMargin = _safetyMargin;
            _currentMargin = _safetyMargin;
            CurrentMargin = _safetyMargin;
            _input = new List<List<int>>();
            Input = _input;
        }

        public void Read(string file)
        {
            string[] input = [.. File.ReadLines(file)];
            foreach (var line in input)
            {
                List<int> Items = [.. line.Split(' ').Select(int.Parse)];
                this.Input.Add(Items);
            }
        }

        // Returns true if an array is strictly increasing or decrasing with at most 'max' difference.
        public bool StrictDiff(List<int> input, int maxDiff)
        {
            if (input.Count < 2)
            {
                return false;
            }
            bool direction = input[0] - input[1] < 0;
            for (int i = 0; i < input.Count - 1; i++)
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

        public bool StrictDampDiff(List<int> input, int maxDiff)
        {
            if (input.Count < 3)
            {
                return false;
            }
            bool direction0 = input[0] - input[1] < 0;
            bool direction1 = input[1] - input[2] < 0;
            bool direction2 = input[2] - input[3] < 0;

            // Sets the direction by consensus of the first four entries.
            bool direction = (direction0 && direction1) || (direction0 && direction2);

            for (int i = 0; i < input.Count - 1; i++)
            {
                // Check for the two safety requirements:
                // Strictly increasing or decreasing, checked by strict and neq.
                bool strict = (input[i] - input[i + 1] < 0) != direction;
                bool neq = input[i] == input[i + 1];
                // Difference limit, checked by diffLimit.
                bool diffLimit = Math.Abs(input[i] - input[i + 1]) > maxDiff;
                if (strict || diffLimit || neq)
                {
                    if (this.CurrentMargin <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        this.CurrentMargin--;
                        for (int j = 0; j < input.Count; j++)
                        {
                            List<int> subInput = input.ToList();
                            subInput.RemoveAt(j);
                            bool subRes = this.StrictDampDiff(subInput, maxDiff);
                            if (subRes)
                            {
                                return true;
                            }
                        }
                        if (this.CurrentMargin <= 0) {
                            return false;
                        }
                    }
                }

            }
            return true;

        }

        public int SafeLevels(int maxDiff, bool dampener)
        {
            int safeLevels = 0;
            foreach (var level in this.Input)
            {
                this.CurrentMargin = this.SafetyMargin;
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
