using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc1q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            Console.Write("String: ");
            var input = Console.ReadLine();
            var charList = input.ToCharArray();//
            var stringList = new List<string>(input.Split(' '));
            Array.Reverse(charList);
            stringList.Reverse();
            Console.WriteLine($"\nReversed String Word by Word\n{string.Join(" ", stringList)}");
            Console.WriteLine("\nReversed String Letter by Letter");
            Console.WriteLine(charList);
            Console.WriteLine();
        }
    }
}
