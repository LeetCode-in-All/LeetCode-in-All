namespace LeetCodeNet.G0001_0100.S0034_find_first_and_last_position_of_element_in_sorted_array {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Binary_Search
// #Algorithm_II_Day_1_Binary_Search #Binary_Search_I_Day_5 #Top_Interview_150_Binary_Search
// #Big_O_Time_O(log_n)_Space_O(1) #2025_06_12_Time_0_ms_(100.00%)_Space_49.94_MB_(35.02%)

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] ans = new int[2];
        ans[0] = Helper(nums, target, false);
        ans[1] = Helper(nums, target, true);
        return ans;
    }

    private int Helper(int[] nums, int target, bool equals) {
        int l = 0;
        int r = nums.Length - 1;
        int result = -1;
        while (l <= r) {
            int mid = l + (r - l) / 2;
            if (nums[mid] == target) {
                result = mid;
            }
            if (nums[mid] < target || (nums[mid] == target && equals)) {
                l = mid + 1;
            } else {
                r = mid - 1;
            }
        }
        return result;
    }
}
}
