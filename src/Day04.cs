namespace AoC.Day04;

class Day04
{
    private bool _partTwo;
    public bool PartOne { get; set; }
    private string[]? _input;
    public string[]? Input { get; set; }
    private List<string> _targetWords;
    public List<string> TargetWords { get; set; }

    public Day04(bool part, string[] targetWords)
    {
        _partTwo = part;
        PartOne = _partTwo;
        _targetWords = new List<string>(targetWords);
        TargetWords = _targetWords;
    }

    public void Read(string fileName)
    {
        Input = File.ReadLines(fileName)
            .ToArray();
    }

    // Follows the word along a direction both in the word and the matrix.
    // matrixDir is the travel direction given in [x, y] coordinates.
    // wordDir is the travel direction in the word given as  1 or -1.
    // Returns true if the whole word is found and false if it is not.
    public bool Trace(string target, int wordPos, int wordDir, int[] matrixPos, int[] matrixDir)
    {
        if (Input == null)
        {
            throw new Exception("no input data");
        }
        // Bounds checking for the target word and the input size.
        while (wordPos < target.Length && wordPos >= 0 && wordPos < Input[matrixPos[0]].Length)
        {
            // Checks that the current character in target word matches the current character in the input.
            if (target[wordPos] != Input[matrixPos[0]][matrixPos[1]])
            {
                return false;
            }
            wordPos += wordDir;
            matrixPos.Zip(matrixDir, (x, y) => x + y);
            if (wordDir < 0 && wordPos < 0)
            {
                return true;
            }
            else if (wordDir > 0 && wordPos == target.Length)
            {
                return true;
            }
        }
        return false;
    }

}
