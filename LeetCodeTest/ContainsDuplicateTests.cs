namespace LeetCodeTest;

public class ContainsDuplicateTests
{
    [SetUp]
    public void Setup() {}

    [Test]
    public void Test1()
    {
        var nums = new int [] { 1,2,3,1 };
        Assert.True(ContainsDuplicate.Solution(nums));
    }

    [Test]
    public void Test2()
    {
        var nums = new int [] { 1,2,3,4 };
        Assert.False(ContainsDuplicate.Solution(nums));
    }

    [Test]
    public void Test3()
    {
        var nums = new int [] { 1,1,1,3,3,4,3,2,4,2 };
        Assert.True(ContainsDuplicate.Solution(nums));
    }
}