namespace LeetCode.BackTracking
{
    public class WordSearchSolution
    {
        public bool Exist(char[][] board, string word)
        {
            for (int row = 0; row < board.Length; row++)
                for (int col = 0; col < board[row].Length; col++)
                    if (board[row][col] == word[0] && SearchDFS(board, word, 0, row, col))
                        return true;

            return false;
        }

        private bool SearchDFS(char[][] board, string word, int position, int row, int col)
        {
            if (position == word.Length)
            {
                return true;
            }
            if (!(0 <= row && row < board.Length && 0 <= col && col < board[row].Length)
                || word[position] != board[row][col])
            {
                return false;
            }

            var cellValue = board[row][col];
            board[row][col] = '-';
            position++;

            var found = SearchDFS(board, word, position, row, col + 1)
                || SearchDFS(board, word, position, row + 1, col)
                || SearchDFS(board, word, position, row, col - 1)
                || SearchDFS(board, word, position, row - 1, col);

            board[row][col] = cellValue;

            return found;
        }
    }
}
