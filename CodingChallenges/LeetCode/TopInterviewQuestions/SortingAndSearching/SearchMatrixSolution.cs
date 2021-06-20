namespace CodingChallenges.LeetCode.TopInterviewQuestions.SortingAndSearching
{
    public class SearchMatrixSolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var row = 0;
            var col = matrix[row].Length - 1;

            while (row < matrix.Length && col >= 0)
            {
                if (matrix[row][col] == target)
                {
                    return true;
                }
                else if (matrix[row][col] > target)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }
            return false;
        }
    }
}
