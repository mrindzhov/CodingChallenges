using System.Collections.Generic;

namespace LeetCode.Arrays
{
    public class MissingRanges
    {
        public string[] FindMissingRanges(int[] nums, int lower, int upper)
        {
            var result = new List<string> { };

            for (int i = 0; i < nums.Length; i++)
            {
                if (lower < nums[i])
                {
                    if (nums[i] - lower == 1)
                        result.Add($"{lower}");
                    else
                        result.Add($"{lower}->{nums[i] - 1}");
                }
                lower = nums[i] + 1;
            }

            if (lower < upper)
                result.Add($"{lower}->{upper}");
            else if (lower == upper)
                result.Add($"{lower}");

            return result.ToArray();

        }
    }
}
