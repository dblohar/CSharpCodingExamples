public int MissingNumber(int[] input)
{
    int n = input.Length + 1;     // Total numbers expected including the missing one
    int expectedSum = n * (n + 1) / 2;
    int actualSum = input.Sum();
    return expectedSum - actualSum;
}
