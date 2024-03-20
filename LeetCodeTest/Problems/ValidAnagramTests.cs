namespace LeetCodeTest;

public class ValidAnagramTests {
    [Test]
    public void Test1() {
        Assert.True(ValidAnagram.Solution("anagram", "nagaram"));
    }

    [Test]
    public void Test2() {
        Assert.False(ValidAnagram.Solution("rat", "car")); 
    }

    [Test]
    public void Test3() { 
        Assert.False(ValidAnagram.Solution("aacc", "ccac")); 
    }

    [Test]
    public void TestDifferentLength() { 
        Assert.False(ValidAnagram.Solution("a", "ab"));
    }
}