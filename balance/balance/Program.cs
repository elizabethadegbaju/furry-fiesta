using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace balance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double balance, interestRate, targetBalance;
            Console.WriteLine("Whatis your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            Console.WriteLine("In {0} year{1} you will have a balance of {2}.", totalYears, totalYears ==1? "":"s", balance);
            int i = 1;
            while (i <= 10)
            {
                if (i == 6)
                    goto exitPoint;
                Console.WriteLine("{0}", i++);
            }
            Console.WriteLine("This code will never be reached.");
        exitPoint:
            Console.WriteLine("This is 6");
            Console.ReadKey();


            int limit, count, sum, i;
            count = 0;
            sum = 0;
            Console.Write("Enter Limit: ");
            limit = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Enter input: ");
                i = Convert.ToInt32(Console.ReadLine());
                sum += i++;
                count++;
            }
            while (count < limit);
            Console.WriteLine("Sum of the integers is {0}", sum);*/


            int limit, count, sum, i;
            sum = 0;
            Console.Write("Enter Limit: ");
            limit = Convert.ToInt32(Console.ReadLine());
            for (count = 0;count<limit ; count ++)
            {
                Console.Write("Enter input: ");             
                i = Convert.ToInt32(Console.ReadLine());
                sum += i++;
            }
            Console.WriteLine("Sum of the integers is {0}", sum);
            Console.ReadKey();
        }
    }
}
