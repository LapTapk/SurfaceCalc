using NUnit.Framework;

[TestFixture]
public class TriangleTest
{
    [Test]
    public void SurfaceCalcTest()
    {
        Assert.That(new Triangle(3, 4, 5).CalcSurface(), Is.EqualTo(6));
        double a = 10, b = 11, c = 16;  
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Assert.That(new Triangle(a, b, c).CalcSurface(), Is.EqualTo(s));
    }
}