using FigureSquareLibrary.Interfaces;
using FigureSquareLibrary.Models;

namespace FigureSquareLibrary.Services
{
    public class ShapeCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }

        public bool IsRightTriangle(Shape shape)
        {
            if (shape is IRightAngledCheckable rightShape)
            {
                return rightShape.IsRightTriangle();
            }

            throw new NotSupportedException("The shape does not support right-angled triangle check.");
        }
    }
}
