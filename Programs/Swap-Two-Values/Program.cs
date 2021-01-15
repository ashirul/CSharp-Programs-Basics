using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc1q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give Two Inputs\n");
            Console.Write("Input 1: ");
            var input1 = Console.ReadLine();
            Console.Write("Input 2: ");
            var input2 = Console.ReadLine();
            swapWithAThird(input1, input2);
            swapWithoutAThird(input1, input2);
        }

        static void swapWithAThird(string first, string second) 
        {
            string third = second;
            second = first;
            first = third;
            Console.WriteLine("Swapping using a Third Variable.");
            Console.WriteLine(String.Format("\nInput 1: {0}\nInput 2: {1}\n", first, second));
        }

        static void swapWithoutAThird(string first, string second)
        {
            first = first + " " + second;
            for (var input = 0; input < first.Length; input++)
            {
                if(first[input] == ' ')
                {
                    second = first.Substring(0, input);
                    first = first.Substring(input).Trim();
                }
            }
            Console.WriteLine("Swapping Without using a Third Variable");
            Console.WriteLine(String.Format("\nInput 1: {0}\nInput 2: {1}\n", first, second));
        }
    }
}
