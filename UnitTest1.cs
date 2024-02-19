using Xunit;
using Lab_3_Library;

namespace Lab_3_Unit_Test
{
    public class AverageCalculatorTests
    {
        [Fact]
        public void Avg_TwoNumbers_ReturnsCorrectAverage()
        {
            double result = AverageCalculator.Avg(4, 6);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Avg_ThreeNumbers_ReturnsCorrectAverage()
        {
            double result = AverageCalculator.Avg(3, 6, 9);
            Assert.Equal(6, result);
        }
    }
}
