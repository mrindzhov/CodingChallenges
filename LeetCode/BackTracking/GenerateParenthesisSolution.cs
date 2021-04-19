using System.Collections.Generic;
using System.Text;

namespace LeetCode.BackTracking
{
    public class GenerateParenthesisSolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            FillArr(result, new StringBuilder(), 0, 0, n * 2);
            return result;
        }

        public void FillArr(IList<string> list, StringBuilder currentWord, int open, int close, int max)
        {
            if (currentWord.Length == max)
            {
                list.Add(currentWord.ToString());
                return;
            }
            if (open * 2 < max)
            {
                currentWord.Append("(");
                FillArr(list, currentWord, open + 1, close, max);
                currentWord.Remove(currentWord.Length - 1, 1);
            }

            if (close < open)
            {
                currentWord.Append(")");
                FillArr(list, currentWord, open, close + 1, max);
                currentWord.Remove(currentWord.Length - 1, 1);
            }
        }
    }
}