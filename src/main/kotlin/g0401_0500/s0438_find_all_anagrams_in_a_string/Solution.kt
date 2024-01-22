package g0401_0500.s0438_find_all_anagrams_in_a_string;

// #Medium #Top_100_Liked_Questions #String #Hash_Table #Sliding_Window
// #Algorithm_II_Day_5_Sliding_Window #Programming_Skills_II_Day_12
// #Level_1_Day_12_Sliding_Window/Two_Pointer #Big_O_Time_O(n+m)_Space_O(1)

class Solution {
    fun findAnagrams(s: String, p: String): List<Int> {
        val map = IntArray(26)
        for (i in 0 until p.length) {
            map[p[i] - 'a']++
        }
        val res: MutableList<Int> = ArrayList()
        var i = 0
        var j = 0
        while (i < s.length) {
            val idx = s[i] - 'a'
            // add the new character
            map[idx]--
            // if the length is greater than windows length, pop the left charcater in the window
            if (i >= p.length) {
                map[s[j++] - 'a']++
            }
            var finish = true
            for (k in 0..25) {
                // if it is not an anagram of string p
                if (map[k] != 0) {
                    finish = false
                    break
                }
            }
            if (i >= p.length - 1 && finish) {
                res.add(j)
            }
            i++
        }
        return res
    }
}
