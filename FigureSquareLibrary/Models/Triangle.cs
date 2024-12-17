using FigureSquareLibrary.Interfaces;

namespace FigureSquareLibrary.Models;

public class Triangle : Shape, IRightAngledCheckable
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        ValidateSides(firstSide, secondSide, thirdSide);
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public override double CalculateArea()
    {
        var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

        var result = Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) *
                         (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        return result;
    }

    public bool IsRightTriangle()
    {
        double[] sides = { FirstSide, SecondSide, ThirdSide };
        Array.Sort(sides);

        var result = Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;

        return result;
    }

    private void ValidateSides(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentException("All sides must be positive.");
        }

        if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
        {
            throw new ArgumentException("The sides do not form a valid triangle.");
        }
    }
}
