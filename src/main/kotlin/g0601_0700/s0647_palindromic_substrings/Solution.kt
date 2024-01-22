package g0601_0700.s0647_palindromic_substrings

// #Medium #Top_100_Liked_Questions #String #Dynamic_Programming #Big_O_Time_O(n^2)_Space_O(n)

class Solution {
    private fun expand(a: CharArray, l: Int, r: Int, res: IntArray) {
        var left = l
        var right = r
        while (left >= 0 && right < a.size) {
            if (a[left] != a[right]) {
                return
            } else {
                res[0]++
                left--
                right++
            }
        }
    }

    fun countSubstrings(s: String): Int {
        val a = s.toCharArray()
        val res = intArrayOf(0)
        for (i in a.indices) {
            expand(a, i, i, res)
            expand(a, i, i + 1, res)
        }
        return res[0]
    }
}
