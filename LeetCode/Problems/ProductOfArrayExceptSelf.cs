namespace LeetCode;

public class ProductOfArrayExceptSelf {
    public static int[] Solution(int[] nums) {
        int product = nums.Aggregate<int>((currentProduct, next) => currentProduct * next);

        int[] ans = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) ans[i] = 0;
            else ans[i] = product / nums[i];
        }
        return ans;
    }
}