using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPA_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string matricNo;
            int noCourses, i;
            double totalUnit = 0;
            double totalMax = 0;
            double grade;
            Console.Write("Enter matriculation number: ");
            matricNo = Console.ReadLine();
            Console.Write("Enter number of courses offered: ");
            noCourses = Convert.ToInt32(Console.ReadLine());
            double[] grades = new double[noCourses];
            int[] units = new int[noCourses];
            for (i = 0; i <noCourses; i++)
            {
                Console.Write("Enter course grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade > 70)
                {
                    grades[i] = 5;
                }
                else if (grade > 60)
                {
                    grades[i] = 4;
                }
                else if (grade > 50)
                {
                    grades[i] = 3;
                }
                else if (grade > 45)
                {
                    grades[i] = 2;
                }
                else if (grade > 40)
                {
                    grades[i] = 1;
                }
                else
                {
                    grades[i] = 0;
                }
                Console.Write("Enter course unit: ");
                units[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < noCourses; i++)
            {
                totalMax += grades[i] * units[i];
                totalUnit += units[i];
            }
            double final = (totalMax / totalUnit);
            Console.Write("\n\nMatriculation Number = " + matricNo + "\nGPA = " + final);
            Console.ReadKey();
        }
    }
}
