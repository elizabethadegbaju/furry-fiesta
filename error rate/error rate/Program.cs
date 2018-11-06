using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace error_rate
{
    class Program
    {
        static void error_printer(string colours){
            char[] atom = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm'};
            int initial = colours.Length;
            int count = 0;
            foreach (char letter in colours)
            {
                foreach (char alphabet in atom)
                {
                    if (letter == alphabet)
                    {
                        count+=1;
                    }
                }
            }
            Console.WriteLine("error rate => {0}/{1}", initial-count, initial);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter colour rate: ");
            string s = Console.ReadLine();
            error_printer(s);
            Console.ReadKey();
        }
    }
}
