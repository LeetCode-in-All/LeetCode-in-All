package g0101_0200.s0128_longest_consecutive_sequence

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Union_Find
// #Big_O_Time_O(N_log_N)_Space_O(1)

import java.util.PriorityQueue

class Solution {
    fun longestConsecutive(nums: IntArray): Int {
        if (nums.isEmpty()) {
            return 0
        }
        val queue = PriorityQueue<Int>()
        nums.forEach {
            queue.add(it)
        }
        var lastNum = Integer.MIN_VALUE
        var length = 0
        var maxLength = 1
        while (queue.isNotEmpty()) {
            val num = queue.poll()
            if (num == lastNum) {
                continue
            }
            length ++
            if (num - lastNum > 1) {
                length = 1
            }
            lastNum = num
            maxLength = maxOf(maxLength, length)
        }
        return maxLength
    }
}
