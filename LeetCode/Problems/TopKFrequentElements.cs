namespace LeetCode;

// Title: 347. Top K Frequent Elements
// Link: top-k-frequent-elements
// Description: Given an integer array nums and an integer k, 
// return the k most frequent elements. You may return the answer in any order.
public class TopKFrequentElements {
    public static int[] Solution(int[] nums, int k) {
        Dictionary<int, int> counter = new();
        foreach (var n in nums) {
            counter[n] = counter.GetValueOrDefault(n, 0) + 1;
        }

        List<int> ans = counter
            .OrderByDescending(x => x.Value)
            .Select(x => x.Key)
            .Take(k)
            .ToList();

        return ans.ToArray();
    }
}