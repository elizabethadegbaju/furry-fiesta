using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace find_next_square
{
    class Program
    {
        static double findNextSquare(int square)
        {
            int root;
            int final;
            root = Convert.ToInt32(Math.Sqrt(square));
            bool check = Math.Pow(root, 2) == square;
            if (check == true)
            {
                root += 1;
                final = Convert.ToInt32(Math.Pow(root, 2));
            }
            else
            {
                final = -1;
            }
                return final;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter perfect square: ");
            int user = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(findNextSquare(user));
            Console.ReadKey();
        }
    }
}
