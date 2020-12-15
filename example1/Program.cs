using System;
using System.Globalization;

namespace example1
{
    class Program
    {
        // задания разбиты на regions, необходимое задание раскомментить
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine("example1");

            //Console.WriteLine("Print a: ");
            //double.TryParse(Console.ReadLine(), out var a);
            //Console.WriteLine("Print b: ");
            //double.TryParse(Console.ReadLine(), out var b);
            //Console.WriteLine("Print c: ");
            //double.TryParse(Console.ReadLine(), out var c);

            //Console.WriteLine((a > Math.Abs(b - c) && (a < b + c)) ? "Can" : "Cannot");
            #endregion

            #region Task 2

            int n, m;
            Console.WriteLine("Print n: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Print m: ");
            int.TryParse(Console.ReadLine(), out m);

            // Рекурсия
            Console.WriteLine($"(R) A(n, m) = {Fact(n) / (Fact(n - m))}");
            // Loop
            Console.WriteLine($"(L) A(n, m) = {Loop(n, m)}");
            #endregion

            #region Task 3

            //Console.WriteLine("Print accuracy: ");
            //long.TryParse(Console.ReadLine(), out var acc);
            //acc = long.MaxValue;

            //long i = 1;
            //double pi = 0;
            //long x = 1;
            //while (i != acc)
            //{
            //    pi += 1.0 / (x * (x + 2));
            //    x += 4;

            //    Console.WriteLine($"Pi = {pi * 8}");
            //    i++;
            //}


            #endregion
        }

        static int Fact(int x)
        {
            return x != 1 ? Fact(x - 1) * x : 1;
        }

        static int Loop(int x, int y)
        {
            var z = 1;
            for (var n = x - y + 1; n <= x; n++)
            {
                z *= n;
            }

            return z;
        }
    }
}
