package g0201_0300.s0215_kth_largest_element_in_an_array

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Sorting #Heap_Priority_Queue
// #Divide_and_Conquer #Quickselect #Data_Structure_II_Day_20_Heap_Priority_Queue
// #Big_O_Time_O(n*log(n))_Space_O(log(n))

class Solution {
    fun findKthLargest(nums: IntArray, k: Int): Int {
        val n = nums.size
        nums.sort()
        return nums[n - k]
    }
}
