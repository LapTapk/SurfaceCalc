public class Circle: ISurfaceCalc
{
    public readonly double Radius;
    public Circle(double radius) => Radius = radius;
    public double CalcSurface()
    {
        return Math.PI * Radius * Radius;
    }
}