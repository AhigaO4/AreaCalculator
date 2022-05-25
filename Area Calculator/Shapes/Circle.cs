namespace Area_Calculator;

public class Circle : IShape
{
    public double R { get; private set; }

    public Circle(double r)
    {
        if (r <= 0)
            throw new Exception("Радиус меньше или равен нулю.");
        R = r;
    }

    public double GetArea() => Math.PI * Math.Pow(R, 2);
    public bool IsEquilateralTriangle() => false;
}