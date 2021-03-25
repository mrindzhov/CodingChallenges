using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SortingAndSearching
{
    public class MergeIntervalsSolution
    {
        public int[][] Merge(int[][] intervals)
        {
            var result = new List<int[]>();
            foreach (var interval in intervals.OrderBy(i => i[0]).ToArray())
            {
                if (result.Count == 0 || interval[0] > result[result.Count - 1][1])
                    result.Add(interval);
                else
                    result[result.Count - 1] = new int[] {
                        Math.Min(result[result.Count - 1][0], interval[0]),
                        Math.Max(result[result.Count - 1][1], interval[1])
                    };
            }

            return result.ToArray();
        }
    }
}
