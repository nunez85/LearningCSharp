namespace LeetCode;

// 217. Contains Duplicate
// Link: contains-duplicate/
// Description: Given an integer array nums, return true if any value appears at 
//      least twice in the array, and return false if every element is distinct.
public class ContainsDuplicate {
    public static bool Solution(int [] nums) {
        var uniq = new HashSet<int>();
        foreach(var num in nums) {
            if (uniq.Contains(num)) {
                return true;
            }
            uniq.Add(num);
        }     
        return false;
    }

}
