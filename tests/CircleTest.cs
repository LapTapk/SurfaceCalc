using NUnit.Framework;

[TestFixture]
public class CircleTest
{
    [Test]
    public void SurfaceCalcTest()
    {
        Assert.That(new Circle(1).CalcSurface(), Is.EqualTo(Math.PI));
        Assert.That(new Circle(5).CalcSurface(), Is.EqualTo(Math.PI * 5 * 5));
    }
}