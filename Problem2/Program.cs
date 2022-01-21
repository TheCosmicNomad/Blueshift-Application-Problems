using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blueshift_Problem2
{
    public class Program
    {
        public static void Main()
        {
            float[] x, s;
            int p;
            float alpha;

            // example 1
            x = new float[] { 50, 60, 40, 30, 90, -5, 40, 50, 30, 40 };
            p = 3;
            alpha = 0.4f;

            s = Smooth(x, p, alpha);

            Console.WriteLine($"x = [{string.Join(", ", x)}]");
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"alpha = {alpha}");
            Console.WriteLine($"s = [{string.Join(", ", s)}]");

            Console.WriteLine();


            // example 2
            x = new float[] { 15, 20, 16, 90, -90, -5, 17, 19, 16, 18 };
            p = 4;
            alpha = 0.5f;

            s = Smooth(x, p, alpha);

            Console.WriteLine($"x = [{string.Join(", ", x)}]");
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"alpha = {alpha}");
            Console.WriteLine($"s = [{string.Join(", ", s)}]");

            Console.WriteLine();
        }

        public static float[] Smooth(float[] x, int p, float alpha)
        {
            float[] s = new float[x.Length];

            // find average of first p terms
            s[0] = 0;
            for (int i = 0; i < p; i++)
            {
                s[0] += x[i];
            }
            s[0] /= p;

            // use provided formula to calculate the rest of the elements
            for (int i = 1; i < s.Length; i++)
            {
                s[i] = Math.Max(alpha * x[i] + (1 - alpha) * s[i - 1], 0);
            }

            return s;
        }
    }
}
