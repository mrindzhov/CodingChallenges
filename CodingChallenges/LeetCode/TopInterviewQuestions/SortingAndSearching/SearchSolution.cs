namespace CodingChallenges.LeetCode.TopInterviewQuestions.SortingAndSearching
{
    public class SearchSolution
    {
        public int Search(int[] nums, int target) =>
            BinarySearch(nums, 0, nums.Length - 1, target);

        private int BinarySearch(int[] nums, int start, int end, int target)
        {
            var mid = (start + end) / 2;

            if (nums[mid] == target)
                return mid;
            else if (start > end)
                return -1;
            else if (nums[start] <= nums[mid]) // LEFT
                return nums[start] <= target && target <= nums[mid] // ENSURE LEFT
                    ? BinarySearch(nums, start, mid - 1, target)
                    : BinarySearch(nums, mid + 1, end, target);

            else // RIGHT
                return nums[mid] <= target && target <= nums[end] // ENSURE RIGHT
                    ? BinarySearch(nums, mid + 1, end, target)
                    : BinarySearch(nums, start, mid - 1, target);

        }
        // [4, 5, 6, 7, 0, 1, 2] 0

        // [8,9,0,1,2,4,5,6,7] 0

        // {5,1,3} 5
    }
}
