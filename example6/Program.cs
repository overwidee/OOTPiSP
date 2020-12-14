using static System.Console;

namespace example6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = new Rational(1, 2);
            var number2 = new Rational(3, 4);
            
            WriteLine($"number1 = {number1}");
            WriteLine($"number2 = {number2}\n");

            WriteLine($"number1 * number2 = {number1.Multiply(number2)}");
            WriteLine($"number1 / number2 = {number1.Divide(number2)}");
            WriteLine($"number1 + number2 = {number1.Add(number2)}");
            WriteLine($"number1 - number2 = {number1.Subtract(number2)}");
            ReadLine();
        }
    }
}