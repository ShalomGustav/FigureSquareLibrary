namespace FigureSquareLibrary.Models;

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        if (Radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive value greater than zero.");
        }

        var shapeCircle = Math.PI * Radius * Radius;

        return shapeCircle;
    }
}