namespace LeetCodeNet.G0001_0100.S0020_valid_parentheses {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #String #Stack
// #Data_Structure_I_Day_9_Stack_Queue #Udemy_Strings #Top_Interview_150_Stack
// #Big_O_Time_O(n)_Space_O(n) #2025_06_12_Time_2_ms_(82.01%)_Space_42.00_MB_(72.34%)

using System;
using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            } else if (c == ')' && stack.Count > 0 && stack.Peek() == '(') {
                stack.Pop();
            } else if (c == '}' && stack.Count > 0 && stack.Peek() == '{') {
                stack.Pop();
            } else if (c == ']' && stack.Count > 0 && stack.Peek() == '[') {
                stack.Pop();
            } else {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
}
