using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.MathProblems
{
    public class IsHappySolution
    {
        public bool IsHappy(int n)
        {
            var history = new HashSet<int>() { };

            while (!history.Contains(n))
            {
                history.Add(n);

                n = (int)n.ToString().ToCharArray()
                    .Select(x => Math.Pow(int.Parse(x.ToString()), 2))
                    .Sum();
            }

            return n == 1;
        }
    }
}
