namespace AoC.Day01
{
    // No need to do all the extra stuff, we only need the diff between the 
    // sum of the right and left lists.
    public class Day01
    {
        private List<int> _leftList;
        public List<int> LeftList {get; set;}
        private List<int> _rightList;
        public List<int> RightList {get; set;}
        private Dictionary<int, int> _occur;
        public Dictionary<int, int> Occur;
        public Day01()
        {
            _leftList = new List<int>();
            LeftList = _leftList;
            _rightList = new List<int>();
            RightList = _rightList;
            _occur = new Dictionary<int, int>();
            Occur = _occur;
        }

        public void Read(string file)
        {
            string[] input = [..File.ReadLines(file)];
            foreach (var line in input) {
                int[] Items = [..line.Split("   ").Select(int.Parse)];
                this.LeftList.Add(Items[0]);
                this.RightList.Add(Items[1]);
            }
        }

        public int CalcPostion() 
        {
            int[] left = this.LeftList.Order()
                .ToArray();
            int[] right = this.RightList.Order()
                .ToArray();
            int res = left.Zip(right, (x, y) => Math.Abs(x - y)).Sum();

            return res;
        }

        public int SimilarityScore() 
        {
            int SimilarityScore = 0;
            int[] left = this.LeftList
                .Order()
                .ToArray();
            int[] right = this.RightList
                .Order()
                .ToArray();

            foreach (int i in right) 
            {
                if (this.Occur.ContainsKey(i))
                {
                    this.Occur[i] += 1;
                } else 
                {
                    this.Occur.Add(i, 1);
                }
            }

            foreach (int i in left) 
            {
                int value;
                if (this.Occur.TryGetValue(i, out value))
                {
                    SimilarityScore += value * i;
                }
            }
            return SimilarityScore;
        }
    }

}
