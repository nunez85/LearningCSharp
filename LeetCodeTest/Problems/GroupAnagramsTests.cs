namespace LeetCodeTest;

public class GroupAnagramsTests {
    [Test]
    public void Test1() {
        string[] input = ["eat","tea","tan","ate","nat","bat"];
        var expected = new List<List<string>>{ 
            new List<string>() { "bat" },
            new List<string>() { "nat", "tan" },
            new List<string>() { "ate", "eat", "tea" },
        };
        IList<IList<string>> actual = GroupAnagrams.Solution(input);
          // Sort the strings within each list for comparison
        var sortedActual = actual.Select(list => list.OrderBy(str => str).ToList()).OrderBy(list => string.Join(",", list)).ToList();
        var sortedExpected = expected.Select(list => list.OrderBy(str => str).ToList()).OrderBy(list => string.Join(",", list)).ToList();
        Assert.That(sortedActual, Is.EqualTo(sortedExpected));

    }

    [Test]
    public void Test2() {
        string[] input = [""];
        var expected = new List<List<string>>{ new List<string>() { "" } };
        var actual = GroupAnagrams.Solution(input);
        Assert.That(actual.OrderBy(x => x), Is.EqualTo(expected.OrderBy(x => x)));
    }

    [Test]
    public void Test3() {
        string[] input = ["a"];
        var expected = new List<List<string>>{ new List<string>() { "a" } };
        var actual = GroupAnagrams.Solution(input);
        Assert.That(actual.OrderBy(x => x), Is.EqualTo(expected.OrderBy(x => x)));
    }
}