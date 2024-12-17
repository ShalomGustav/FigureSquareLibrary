using FigureSquareLibrary.Models;
using FigureSquareLibrary.Services;

namespace FigureShapeLibrary.Tests
{
    public class FigureShapeTests
    {
        private readonly ShapeCalculator _calculator = new();

        [Fact]
        public void CircleAreaTest()
        {
            // Arrange
            var circle = new Circle(5);
            var expected = Math.PI * 25;

            // Act
            var actual = _calculator.CalculateArea(circle);

            // Assert
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expected = 6;

            // Act
            var actual = _calculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var result = _calculator.IsRightTriangle(triangle);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TriangleInvalidSidesTest()
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));

            Assert.Equal("The sides do not form a valid triangle.", exception.Message);
        }
    }
}