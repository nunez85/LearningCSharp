namespace LeetCode;

// Title: 1. Two Sum
// Link: two-sum/
// Description: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
public class TwoSum {
    public static int[] Solution(int[] nums, int target) {
        var d = new Dictionary<int, int>();
        int diff = 0;
        for (int i = 0; i < nums.Length; i++) {
            diff = target - nums[i];
            if (d.ContainsKey(diff)) {
                return [d[diff], i];
            } else {
                d[nums[i]] = i;
            }
        }
        return [];
    }
}
