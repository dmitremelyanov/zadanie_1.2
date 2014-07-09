using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double D;
            double x1, x2;

            Console.Write("Введите значение коэфициента а:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэфициента b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэфициента c:");
            c = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(b, 2) - 4 * a * c;
            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x1= {0}", x1);
                Console.WriteLine("x2= {0}", x2);

            }
            else
                Console.WriteLine("Действительных корней нет");

            Console.ReadKey();

        }
    }
}