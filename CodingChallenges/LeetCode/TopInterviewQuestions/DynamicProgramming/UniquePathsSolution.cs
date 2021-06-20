using System.Text;

namespace CodingChallenges.LeetCode.TopInterviewQuestions.DynamicProgramming
{
    /// <summary>
    /// A robot is located at the top-left corner of a m x n grid(marked 'Start' in the diagram below).
    /// The robot can only move either down or right at any point in time.The robot is trying to reach the bottom-right corner of the grid(marked 'Finish' in the diagram below).
    /// How many possible unique paths are there?
    /// </summary>
    public class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            var board = new int[m, n];
            for (int i = 0; i < m; i++)
                board[i, 0] = 1;

            for (int i = 0; i < n; i++)
                board[0, i] = 1;

            for (int row = 1; row < m; row++)
                for (int col = 1; col < n; col++)
                    board[row, col] = board[row - 1, col] + board[row, col - 1];

            return board[m - 1, n - 1];
        }
    }
    public static class Utils
    {
        public static string ToMatrixString<T>(this T[,] matrix, string delimiter = "\t")
        {
            var s = new StringBuilder();

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    s.Append(matrix[i, j]).Append(delimiter);
                }

                s.AppendLine();
            }

            return s.ToString();
        }
    }
}
