using System;
using System.Linq;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("example2");

            #region Task 1

            //Console.WriteLine("Print n: ");

            //int.TryParse(Console.ReadLine(), out var n);

            //var array = new double[n];

            //for (var i = 0; i < n; i++)
            //{
            //    double.TryParse(Console.ReadLine(), out array[i]);
            //}

            //Console.WriteLine($"Average: {array.Where((x, index) => index % 2 == 0).Average()}");

            #endregion

            #region Task 2

            var arr = new double[,]
            {
                {1, 2, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, 4}
            };

            var tArr = new double[arr.GetLength(0), arr.GetLength(1)];

            Console.WriteLine("Old array\n");
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    tArr[j, i] = arr[i, j];
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("New array\n");
            for (var i = 0; i < tArr.GetLength(0); i++)
            {
                for (var j = 0; j < tArr.GetLength(1); j++)
                {
                    Console.Write(tArr[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            #endregion
            Console.ReadLine();
        }
    }
}
