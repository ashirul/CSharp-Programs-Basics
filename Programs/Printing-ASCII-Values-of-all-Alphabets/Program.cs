using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc1q7
{
    class Program
    {
        static string alphabetArray = "abcdefghijklmnopqrstuvwxyz";
        static void Main(string[] args)
        {
            Console.WriteLine("Upper Case Alphabets with ASCII\n");
            upperCaseAscii();
            Console.WriteLine("Lower Case Alphabets with ASCII\n");
            lowerCaseAscii();
        }

        static void upperCaseAscii()
        {
            var counter = 0;
            foreach(var letter in alphabetArray.ToUpper())
            {
                Console.Write(String.Format("{0}: {1}   ", letter, (int)letter));
                counter++;
                if (counter % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
        }
        static void lowerCaseAscii()
        {
            var counter = 0;
            foreach (var letter in alphabetArray)
            {
                counter++;
                {
                    if(counter == 2)
                        Console.Write(String.Format(" {0}: {1}   ", letter, (int)letter));
                    else if (counter == 3)
                        Console.Write(String.Format(" {0}: {1}   ", letter, (int)letter));
                    else if (counter == 4)
                        Console.Write(String.Format(" {0}: {1}   ", letter, (int)letter));
                    else
                        Console.Write(String.Format("{0}: {1}   ", letter, (int)letter));
                }
                if (counter % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
        }
    }
}
