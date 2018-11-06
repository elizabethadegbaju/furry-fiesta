using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrays
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int max = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > max)
                    max = intArray[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            /*string[] friendNames = {"Christabel", "Winnie", "Ladele"};
            int i;
            Console.WriteLine("Here are {0} of my friends: ", friendNames.Length);
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }
            Console.WriteLine();

            foreach (string friend in friendNames)
            {
                Console.WriteLine(friend);
            }*/
             

            int[,] numbers = new int[4, 3];
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter an integer: ");
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 4; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write(numbers[i, j] + "\t");
                }
            }
            /*string myString = "This is a string.";
            char[] separator = {' '};
            myString = myString.ToUpper();
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }

            /*int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxVal = MaxValue(myArray);
            Console.WriteLine("The maximum value in myArray is {0}", maxVal);*/
            Console.ReadKey();
        }
    }
}
