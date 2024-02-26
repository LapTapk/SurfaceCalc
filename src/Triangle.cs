public class Triangle : ISurfaceCalc
{
    public readonly double A, B, C;
    public bool IsRectangular
    {
        get
        {
            bool v1 = A * A + B * B == C * C;
            bool v2 = A * A + C * C == B * B;
            bool v3 = B * B + C * C == A * A;
            return v1 || v2 || v3;
        }
    }
    public Triangle(double a, double b, double c)
    {
        bool v1 = a + b < c;
        bool v2 = a + c < b;
        bool v3 = b + c < a;
        if (v1 || v2 || v3)
        {
            throw new Exception($"No triangle with sides {a}, {b}, {c}");
        }

        (A, B, C) = (a, b, c);
    }
    public double CalcSurface()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}