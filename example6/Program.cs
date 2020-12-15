using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace example6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            // var number1 = new Rational(1, 2);
            // var number2 = new Rational(3, 4);
            //
            // WriteLine($"number1 = {number1}");
            // WriteLine($"number2 = {number2}\n");
            //
            // WriteLine($"number1 * number2 = {number1.Multiply(number2)}");
            // WriteLine($"number1 / number2 = {number1.Divide(number2)}");
            // WriteLine($"number1 + number2 = {number1.Add(number2)}");
            // WriteLine($"number1 - number2 = {number1.Subtract(number2)}");

            #endregion

            #region Task 2

            var incomes = new List<Income>
            {
                new MainWork(1000), 
                new SecondWork(500), 
                new Royalty(350),
                new Sales(998),
                new Gift(3354),
                new Transfer(3300),
                new Privilege(445)
            };
            
            var sortList = incomes.OrderByDescending(x => ((ITax) x).GetTaxSum()).ToList();
            
            foreach (var income in sortList)
            {
                WriteLine($"{income.GetName()} - {Math.Round(((ITax)income).GetTaxSum(), 2)}");
            }

            #endregion

            ReadLine();
        }
    }
}