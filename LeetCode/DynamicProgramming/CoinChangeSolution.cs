using System;

namespace LeetCode.DynamicProgramming
{
    /// <summary>
    /// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
    /// Return the fewest number of coins that you need to make up that amount.If that amount of money cannot be made up by any combination of the coins, return -1.
    /// You may assume that you have an infinite number of each kind of coin.
    /// </summary>
    public class CoinChangeSolution
    {
        public int CoinChange(int[] coins, int amount)
        {
            if (amount < 1) return 0;
            return CoinChangeDPTopDown(coins, amount, new int[amount]);
        }

        private int CoinChangeDPTopDown(int[] coins, int rem, int[] count)
        {
            if (rem < 0) return -1;
            if (rem == 0) return 0;
            if (count[rem - 1] != 0) return count[rem - 1];
            int min = int.MaxValue;

            foreach (var coin in coins)
            {
                int res = CoinChangeDPTopDown(coins, rem - coin, count);
                if (res >= 0 && res < min)
                    min = 1 + res;
            }
            count[rem - 1] = (min == int.MaxValue) ? -1 : min;
            return count[rem - 1];
        }


        private int CoinChangeBacktracking(int[] coins, int amount, int coinIdx = 0)
        {
            if (amount == 0)
                return 0;
            if (coinIdx >= coins.Length)
                return -1;

            var maxVal = amount / coins[coinIdx];
            var minCost = int.MaxValue;
            for (int i = 0; i <= maxVal; i++)
            {
                var sum = i * coins[coinIdx];
                if (amount >= sum)
                {
                    var res = CoinChangeBacktracking(coins, amount - sum, coinIdx + 1);
                    if (res != -1)
                    {
                        minCost = Math.Min(minCost, res + i);
                    }
                }
            }
            return minCost == int.MaxValue ? -1 : minCost;
        }
    }
}
