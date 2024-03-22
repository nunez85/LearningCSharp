namespace LeetCodeTest;

public class TwoSumTests {

    [Test]
    public void Test1() {
        var expected = new int[] {0, 1};
        var actual = TwoSum.Solution([2,7,11,15], 9);
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void Test2() {
        var expected = new int[] { 1, 2, };
        var actual = TwoSum.Solution([3,2,4], 6);
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void Test3() {
        var expected = new int[] {0, 1};
        var actual = TwoSum.Solution([2,7,11,15], 9);
        Assert.That(expected, Is.EqualTo(actual));
    }
}