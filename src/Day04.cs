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

    public void Read(string fileName) => Input = File.ReadLines(fileName)
            .ToArray();

    // Follows the word along a direction both in the word and the matrix.
    // inputDir is the travel direction given in [x, y] coordinates.
    // wordDir is the travel direction in the word given as  1 or -1.
    // Returns true if the whole word is found and false if it is not.
    public bool Trace(string target, int wordPos, int wordDir, int[] inputPos, int[] inputDir)
    {
        if (Input == null)
        {
            return false;
        }
        // Trace input matrix for the target word at given position.
        while (
                // Is the x-coordinate within the row length.
                inputPos[0] >= 0 && inputPos[0] < Input[inputPos[0]].Length &&
                // Is the y-coordinate within the column limit.
                inputPos[1] >= 0 && inputPos[1] < Input.Length &&
                // Is the word slider within bounds.
                wordPos < target.Length && wordPos >= 0
                )
        {
            // Compare current position with the next character.
            if (target[wordPos] != Input[inputPos[0]][inputPos[1]])
            {
                return false;
            }
            // Move positioning along.
            wordPos += wordDir;
            inputPos.Zip(inputDir, (x, y) => x + y);
            // Completion check.
            switch (wordDir)
            {
                // Backwards direction.
                case < 0 when wordPos < 0:
                    return true;
                // Forwards direction.
                case > 0 when wordPos == target.Length:
                    return true;
            }
        }
        return false;
    }

}
