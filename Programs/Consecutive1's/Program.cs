using System;
using System.Collections.Generic;

namespace poc1q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            var input = Console.ReadLine();
            Console.WriteLine(consecutiveones(input));
        }

        static string binary(string input)
        {
            var binBit = new List<long>();
            var temp = Convert.ToInt64(input);
            while (temp > 0)
            {
                binBit.Add(temp % 2);
                temp = temp / 2;
            }
            binBit.Reverse();
            return string.Join("",binBit);
        }

        static int consecutiveones(string bin)
        {
            
            var tempBin = binary(bin);
            Console.WriteLine(tempBin);
            var count = 1;
            for(var i = 0; i < tempBin.Length-1; i++)
            {
                if (tempBin[i] == '1' && tempBin[i + 1] == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
