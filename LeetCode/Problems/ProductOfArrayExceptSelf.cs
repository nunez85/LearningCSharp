namespace LeetCode;

public class ProductOfArrayExceptSelf {
    public static int[] Solution(int[] nums) {
        int[] res = new int[nums.Length];
        int prefix = 1;
        for (int i = 0; i < nums.Length; i++) {
            res[i] = prefix;
            prefix *= nums[i];
        }

        int postfix = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            res[i] *= postfix;
            postfix *= nums[i];
        }

        return res;
    }

    public static int[] SolutionWithDivision(int[] nums) {
        int product = nums.Aggregate<int>((currentProduct, next) => currentProduct * next);

        int[] ans = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) ans[i] = 0;
            else ans[i] = product / nums[i];
        }
        return ans;
    }
}