using System;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("example1");

            double a, b, c;

            Console.WriteLine("Print a: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Print b: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Print c: ");
            double.TryParse(Console.ReadLine(), out c);

            Console.WriteLine((a > Math.Abs(b - c) && (a < b + c)) ? "Can" : "Cannot");
            #endregion

            #region Task 2

            #endregion


        }
    }
}
