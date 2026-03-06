namespace demo
{
    public class Calculator
    {
        public int add(int x, int y)
        {
            if (x < 1 || y < 1)
            {
                throw new ArgumentException("Метод принимает только целые положительные числа");
            }

            return checked(x + y);
        }
    }
}
