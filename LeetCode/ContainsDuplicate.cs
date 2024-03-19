namespace LeetCode;

// 217. Contains Duplicate
public class ContainsDuplicate
{
    public static bool Solution(int [] nums)
    {
        var uniq = new HashSet<int>();
        foreach(var num in nums)
        {
            if (uniq.Contains(num))
            {
                return true;
            }
            uniq.Add(num);
        }     
        return false;
    }

}
