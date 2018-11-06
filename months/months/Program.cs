using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace months
{
    class Program
    {
        static void checkmonths(int x, int y)
        {
            Console.WriteLine("There are {0} months between them", y - (x + 1));
        }
        static void checkmonthsname(int x, int y)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int i = 1;
            string first = "";
            string second = "";
            foreach (string month in months)
            {
                if (x == i)
                    first = month;
                else if (y == i)
                    second = month;
                i++;
            }
            Console.WriteLine("There are {0} months between {1} and {2}.", y - (x + 1), first, second);
        }
        static void Main(string[] args)
        {
            int val1, val2;
            Console.Write("Enter first value: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            if ((val1 < 1) || (val1 > 12))
                Console.WriteLine("Error!");
            else if ((val2 < 1) || (val2 > 12))
                Console.WriteLine("Error!");
            checkmonthsname(val1, val2);
            checkmonths(val1, val2);
            Console.ReadKey();
        }
    }
}
