using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Numbers_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WorkWithIntegers();
            OrderPrecedence();

            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double l = 5;
            double m = 4;
            double n = 2;
            double o = (l + m) / n;
            Console.WriteLine(o);

            double p = 19;
            double q = 23;
            double r = 8;
            double s = (p + q) / r;
            Console.WriteLine(s);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);


            void WorkWithIntegers()
            {
                int a = 18;
                int b = 6;
                int c = a + b;
                Console.WriteLine(c);


                // subtraction
                c = a - b;
                Console.WriteLine(c);

                // multiplication
                c = a * b;
                Console.WriteLine(c);

                // division
                c = a / b;
                Console.WriteLine(c);
            }

            void OrderPrecedence()
            {
                int a = 5;
                int b = 4;
                int c = 2;
                int d = a + b * c;
                Console.WriteLine(d);

                d = (a + b) * c;
                Console.WriteLine(d);

                d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
                Console.WriteLine(d);

                int e = 7;
                int f = 4;
                int g = 3;
                int h = (e + f) / g;
                Console.WriteLine(h);
            }


        }


    }
}
