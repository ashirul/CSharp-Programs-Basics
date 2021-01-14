using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc1q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series till 50");

            var fibSeries = fibTillFifty();

            Console.WriteLine(fibSeries);
        }
        static string fibTillFifty()
        {
            var fib = new List<long>();
            long a = 0, b = 1, c;
            fib.Add(a);
            fib.Add(b);

            for (var i = 1; i <= 48; i++)
            {
                c = a + b;
                fib.Add(c);
                a = b;
                b = c;
            }
            return string.Join(",", fib);
        }
    }
}
