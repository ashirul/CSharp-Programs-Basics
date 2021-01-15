using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (temp != 0)
            {
                while (temp > 0)
                {
                    binBit.Add(temp % 2);
                    temp = temp / 2;
                }
                binBit.Reverse();
                return string.Join("", binBit);
            }
            else if (temp == 0)
                return "0";
            return "";
        }

        static int consecutiveones(string bin)
        {
            var tempBin = binary(bin);
            var onlyOnes = tempBin.Split('0');
            var count = 0;
            if(bin == "0")
            {
                return 0;
            }
            else
            {
                Array.Sort(onlyOnes);
                count = Convert.ToInt32(onlyOnes[onlyOnes.Length - 1].Length);
                Console.WriteLine();
                if (count == 0)
                    count = 1;
                Console.WriteLine(tempBin);
                return count;
            }
        }
    }
}
