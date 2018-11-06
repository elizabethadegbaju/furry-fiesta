using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum_of_numbers
{
    class Program
    {
        static int odd()
        {
            int count;
            int sum = 0;
            for (count = 1; count <= 100; count += 2)
            {
                sum += count;
            }
            return sum;
        }
        static int even()
        {
            int count;
            int sum = 0;
            for (count = 0; count <= 100; count += 2)
            {
                sum += count;
            }
            return sum;
        }
        static int both()
        {
            return odd() + even();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(odd());
            Console.WriteLine(even());
            Console.WriteLine(both());
            Console.ReadKey();
        }
    }
}
