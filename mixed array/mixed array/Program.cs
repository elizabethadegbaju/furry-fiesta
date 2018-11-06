using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mixed_array
{
    class Program
    {
        static int LOOK(int[,] numbers)
        {
            int max = numbers[0,0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        static void MUL(int[,] numbers)
        {
            int max = LOOK(numbers);
            int count = 0;
            int i,j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (count < 4)
                    {
                        numbers[i, j] *= max;
                    }
                    count++;
                }
            }
            count = 1;
            foreach (int number in numbers)
            {
                if ((count % 4) == 0)
                {
                    Console.Write("{0}\n", number);
                }
                else
                {
                    Console.Write("{0}\t", number);
                }
                count++;
            }
        }
        static void Main(string[] args)
        {
            int[,] values = new int[3,4];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("Enter value: ");
                    values[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Largest value is {0}.", LOOK(values));
            MUL(values);
            Console.ReadKey();
        }
    }
}
