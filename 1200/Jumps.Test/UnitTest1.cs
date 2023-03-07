namespace Jumps.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(1, Res.Resolve(1));
        Assert.AreEqual(2, Res.Resolve(3));
        Assert.AreEqual(2, Res.Resolve(2));
        Assert.AreEqual(3, Res.Resolve(6));
        Assert.AreEqual(3, Res.Resolve(4));
        Assert.AreEqual(4, Res.Resolve(10));
        Assert.AreEqual(4, Res.Resolve(8));
        Assert.AreEqual(4, Res.Resolve(5));

        Assert.Pass();
    }
}