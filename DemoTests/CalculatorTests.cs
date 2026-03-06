using demo;

namespace DemoTests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTwoPositive_ReturnSum()
        {
            var calc = new Calculator();

            Assert.Equal(2, calc.Add(1, 1));
        }

        [Fact]
        public void AddTwoNegative_ReturnSum()
        {
            var calc = new Calculator();
            Assert.Throws<ArgumentException>(() => calc.Add(-1, -3));
        }
    }
}