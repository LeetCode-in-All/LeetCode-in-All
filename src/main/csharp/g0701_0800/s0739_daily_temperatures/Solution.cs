namespace LeetCodeNet.G0701_0800.S0739_daily_temperatures {

// #Medium #Top_100_Liked_Questions #Array #Stack #Monotonic_Stack #LeetCode_75_Monotonic_Stack
// #Programming_Skills_II_Day_6 #Big_O_Time_O(n)_Space_O(n)
// #2025_06_16_Time_6_ms_(98.90%)_Space_66.59_MB_(99.02%)

public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] sol = new int[temperatures.Length];
        sol[temperatures.Length - 1] = 0;
        for (int i = sol.Length - 2; i >= 0; i--) {
            int j = i + 1;
            while (j <= sol.Length) {
                if (temperatures[i] < temperatures[j]) {
                    sol[i] = j - i;
                    break;
                } else {
                    if (sol[j] == 0) {
                        break;
                    }
                    j = j + sol[j];
                }
            }
        }
        return sol;
    }
}
}
