using System;

namespace CodingChallenges.LeetCode.TopInterviewQuestions.Arrays
{
    public class IncreasingTripletSolution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3) return false;

            var i = int.MaxValue;
            var j = int.MaxValue;

            foreach (var num in nums)
            {
                if (num <= i) i = num;
                else if (num <= j) j = num;
                else return true;
            }

            return false;
        }

        public bool IncreasingTripletMinMax(int[] nums)
        {
            var n = nums.Length;
            if (n < 3) return false;

            var leftMin = new int[n];
            leftMin[0] = nums[0];
            for (int i = 1; i < n; i++)
                leftMin[i] = Math.Min(leftMin[i - 1], leftMin[i]);

            var rightMax = new int[n];
            rightMax[n - 1] = nums[n - 1];
            for (int i = n - 2; i >= 0; i--)
                rightMax[i] = Math.Max(rightMax[i + 1], rightMax[i]);


            for (int i = 0; i < n; i++)
                if (leftMin[i] < nums[i] && nums[i] < rightMax[i])
                    return true;

            return false;
        }
        public bool IncreasingTripletBruteForce(int[] nums)
        {
            var n = nums.Length;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    for (int k = j + 1; k < n; k++)
                        if (nums[i] < nums[j] && nums[j] < nums[k])
                            return true;

            return false;
        }
    }
}
