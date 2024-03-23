namespace LeetCode;

// Title: 49 Group Anagrams
// Link: group-anagrams
// Description: Given an array of strings strs, group the anagrams together.
// You can return the answer in any order. 
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
// typically using all the original letters exactly once.

public class GroupAnagrams {
    public static IList<IList<string>> Solution(string[] strs) {
        var groups = new Dictionary<string, List<string>>();
        foreach (var str in strs) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);

            if (!groups.ContainsKey(sorted)) groups[sorted] = new List<string>();

            groups[sorted].Add(str);
        }

        return groups.Select(x => x.Value).ToList<IList<string>>();
    }
}