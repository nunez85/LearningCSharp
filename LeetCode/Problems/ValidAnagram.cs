namespace LeetCode;

// Title: 242. Valid Anagram
// Link: valid-anagram/
// Description: Given two strings s and t, return true if t is an anagram of s, and false otherwise.
//      An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
//      typically using all the original letters exactly once.
public class ValidAnagram {
    public static bool Solution(string s, string t) {
        if (s.Length != t.Length) return false;

        var ds = new Dictionary<char, int>();
        foreach (char c in s) {
            ds[c] = ds.GetValueOrDefault(c, 0) + 1;
        }

        var dt = new Dictionary<char, int>();
        foreach (char c in t) {
            dt[c] = dt.GetValueOrDefault(c, 0) + 1;
        }

        foreach (var (c, s_count) in ds) {
            if (dt.GetValueOrDefault(c, -1) != s_count){
                return false;
            }
        }
        
        return true;
    }
}