namespace LeetCode.SortingAndSearching
{
    public class FindPeakElementSolution
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length == 2)
                return nums[0] > nums[1] ? 0 : 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i] && (i + 1 == nums.Length || nums[i] > nums[i + 1]))
                    return i;
            }
            return 0;
        }
    }
}
