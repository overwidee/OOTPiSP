using System;
using System.Collections.Generic;
using example3.Models;

namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            var employee = new Employee("Шичко", "Павел", "Викторович", new DateTime(2000, 7, 11),
                new User("login", "qwerty1", "the-shichko"),
                new Transport("Комбэйн", TransportType.Harvester, "0098-am", "PRIORA"));

            var employee2 = new Employee("Фамилия", "Имя", "Викторович", new DateTime(2000, 7, 11),
                new User("log2in", "qwerty21", "the-shichko2"),
                new Transport("Комбэйн", TransportType.Harvester, "0098-am", ""));
            
            var grain = new GrainHarvesting() {employee, employee2};
            grain[0].AddTones(50);
            grain[1].AddTones(100);

            Console.WriteLine(grain.GetTotal());
            Console.WriteLine(grain.GetBest());
            

            #endregion

            #region Task2
            
            // var square = new Square(5);
            // square.Increase(100);
            //
            // Console.WriteLine($"Wall: {square.GetWall()}");
            // Console.WriteLine($"Perimeter: {square.GetPerimeter()}");
            // Console.WriteLine($"Area: {square.GetArea()}");
            // Console.WriteLine($"Diagonal: {square.GetDiagonal()}");
            
            #endregion

            Console.ReadKey();
        }
    }
}