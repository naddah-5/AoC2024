namespace AoC.Day03
{
    public class Day03
    {
        private bool _partTwo;
        public bool PartTwo { get; }
        private bool _do;
        public bool Do { get; set; }
        private List<string> _input;
        public List<string> Input { get; set; }
        private List<int[]> _parsed;
        public List<int[]> Parsed { get; set; }
        public Day03(bool partTwo)
        {
            _partTwo = partTwo;
            PartTwo = _partTwo;
            _do = true;
            Do = _do;
            _input = new List<string>();
            Input = _input;
            _parsed = new List<int[]>();
            Parsed = _parsed;
        }

        public void Read(string file)
        {
            {
                string[] input = [.. File.ReadLines(file)];
                foreach (var line in input)
                {
                    if (PartTwo)
                    {
                        Input.Add(FilterMul(line));
                    }
                    else
                    {
                        Input.Add(line);
                    }
                }
            }
        }

        // Parses the input into the the Parsed field.
        public void Parse()
        {
            var mulOps = new List<int[]>();
            foreach (var line in Input)
            {
                var tmp = MulParse(line);
                foreach (var item in tmp)
                    try
                    {
                        {
                            mulOps.Add(OperandParse(item));
                        }
                    }
                    catch
                    {
                        continue;
                    }
            }
            Parsed = mulOps;
        }


        public string FilterMul(string input)
        {
            if (input == "")
            {
                return input;
            }
            if (Do)
            {
                var i = input.IndexOf("don't()");
                if (i < 0)
                {
                    return input;
                }
                var head = input.Substring(0, i);
                var tail = input.Substring(i + "don't".Length);
                Do = false;
                return head + FilterMul(tail);
            }
            else
            {
                var i = input.IndexOf("do()");
                if (i < 0)
                {
                    return "";
                }
                var head = input.Substring(0, i);
                var tail = input.Substring(i + "do".Length);
                Do = true;
                return FilterMul(tail);
            }
        }

        // Parses a string into all valid multiplication operations.
        // This does not check that the operators are valid!
        public List<string[]> MulParse(string input)
        {
            var res = new List<string[]>();
            var mulOps = input.Split("mul")
                .Where(p => (p.Contains('(') && p.Contains(',') && p.Contains(')')) == true);
            foreach (var operand in mulOps)
            {
                var op = operand
                    .Substring(1, operand.IndexOf(')') - 1)
                    .Split(',');
                res.Add(op);
            }
            return res;
        }

        // Parses an array of strings int an array of integers.
        public int[] OperandParse(string[] input)
        {
            var res = new int[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                int tmp = 0;
                if (input[i].Contains(" "))
                {
                    throw new FormatException();
                }
                bool ok = Int32.TryParse(input[i], out tmp);
                if (ok)
                {
                    res[i] = tmp;
                }
                else
                {
                    throw new FormatException();
                }
            }
            return res;
        }

        public int Calc()
        {
            int res = 0;
            foreach (var mulOp in Parsed)
            {
                int tmp = 1;
                foreach (int x in mulOp)
                {
                    tmp *= x;
                }
                res += tmp;
            }
            return res;
        }

    }
}
