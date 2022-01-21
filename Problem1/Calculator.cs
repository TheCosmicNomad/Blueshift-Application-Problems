namespace Blueshift_Problem1
{
    public class Calculator
    {
        // calculator functions
        public string Copy(int n)
        {
            return n.ToString();
        }

        public string Factorial(int n)
        {
            int total = 1;
            for (int i = 1; i <= n; i++)
            {
                total *= i;
            }
            return total.ToString();
        }

        public string EvenOdd(int n)
        {
            return n % 2 == 0 ? "Even" : "Odd";
        }
    }
}
