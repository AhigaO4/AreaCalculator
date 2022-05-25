namespace Area_Calculator;

public class Triangle : IShape
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }
    
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new Exception("Одна из сторон меньше или равна нулю.");
        A = a;
        B = b;
        C = c;
    }

    public double GetArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsEquilateralTriangle() => A == B && A == C;
}