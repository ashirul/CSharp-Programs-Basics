using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc1q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            var input = Convert.ToInt32(Console.ReadLine());
            armstrong(input);
        }
        static void armstrong(int input)
        {
            var temp = input;
            var inputLength = input.ToString().Length;
            int rem, sum = 0;
            while ( temp > 0 )
            {
                int pow = 1;
                rem = temp % 10;
                for (var i = 0; i < inputLength; i++)
                    pow = rem * pow;
                sum = sum + pow;
                temp = temp / 10;
            }
            if(sum == input)
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("Not Armstrong");
        }
    }
}
