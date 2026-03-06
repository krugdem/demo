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

        [Fact]
        public void test2()
        {
            var calc = new Calculator();
            int a = 123;
            int b = 3;
            Assert.Equal(a + b, calc.Add(a, b));
        }
    }
}