namespace LeetCode;

public class TopKFrequentElementsTests {
    [Test]
    public void Test1() {
        int[] expected = [1,2];
        var actual = TopKFrequentElements.Solution([1,1,1,2,2,3], 2);
        Assert.That(expected, Is.EqualTo(actual));
    }
}