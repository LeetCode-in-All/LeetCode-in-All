namespace LeetCodeNet.G0001_0100.S0039_combination_sum {

// #Medium #Top_100_Liked_Questions #Array #Backtracking #Algorithm_II_Day_10_Recursion_Backtracking
// #Level_2_Day_20_Brute_Force/Backtracking #Udemy_Backtracking/Recursion
// #Top_Interview_150_Backtracking #Big_O_Time_O(2^n)_Space_O(n+2^n)
// #2025_06_12_Time_1_ms_(100.00%)_Space_48.21_MB_(42.68%)

using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> CombinationSum(int[] coins, int amount) {
        IList<IList<int>> ans = new List<IList<int>>();
        List<int> subList = new List<int>();
        CombinationSumRec(coins.Length, coins, amount, subList, ans);
        return ans;
    }

    private void CombinationSumRec(
            int n, int[] coins, int amount, List<int> subList, IList<IList<int>> ans) {
        if (amount == 0 || n == 0) {
            if (amount == 0) {
                List<int> baseList = new List<int>(subList);
                ans.Add(baseList);
            }
            return;
        }
        if (amount - coins[n - 1] >= 0) {
            subList.Add(coins[n - 1]);
            CombinationSumRec(n, coins, amount - coins[n - 1], subList, ans);
            subList.RemoveAt(subList.Count - 1);
        }
        CombinationSumRec(n - 1, coins, amount, subList, ans);
    }
}
}
