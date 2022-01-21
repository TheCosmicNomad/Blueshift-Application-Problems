namespace Blueshift_Problem1
{
    public class Calculator
    {

        private Dictionary<string, Func<int, string>> calculationModes;

        public Calculator()
        {
            calculationModes = new Dictionary<string, Func<int, string>>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "Copy", Copy },
                { "Factorial", Factorial },
                { "EvenOdd", EvenOdd }
            };
        }

        public bool IsMode(string mode)
        {
            return calculationModes.ContainsKey(mode);
        }

        public string[] GetAllModes()
        {
            return calculationModes.Keys.ToArray();
        }

        public string Calculate(string mode, int n)
        {
            return calculationModes[mode](n);
        }

        // calculator functions
        private string Copy(int n)
        {
            return n.ToString();
        }

        private string Factorial(int n)
        {
            int total = 1;
            for (int i = 1; i <= n; i++)
            {
                total *= i;
            }
            return total.ToString();
        }

        private string EvenOdd(int n)
        {
            return n % 2 == 0 ? "Even" : "Odd";
        }
    }
}
