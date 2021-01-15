using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc1q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            Console.Write("Input: ");
            var input = Console.ReadLine();
            palindrome(input);
        }

        static void palindrome(string input)
        {
            var inputLength = input.Length;
            var temp ="";
            for(var i = inputLength-1; i >= 0; i--)
            {
                temp = temp + input[i];
            }
            if (temp == input)
                Console.WriteLine("Palindrome"); 
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
