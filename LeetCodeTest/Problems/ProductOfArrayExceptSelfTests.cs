namespace LeetCodeTest;

public class ProductOfArrayExceptSelfTests {
    [Test]
    public void Test1() {
        int[] expected = [24,12,8,6];
        int[] actual = ProductOfArrayExceptSelf.Solution([1, 2, 3, 4]);
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void Test2() {
        int[] expected = [-1,1,0,-3,3];
        int[] actual = ProductOfArrayExceptSelf.Solution([-1,1,0,-3,3]);
        Assert.That(expected, Is.EqualTo(actual));
    }
}