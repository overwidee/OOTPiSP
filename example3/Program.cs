using System;
using System.Collections.Generic;
using System.Linq;
using example3.Models;

namespace example3
{
    class Program
    {
        // для выполнения определенный заданий (Task1, Task2) - раскомментить код
        static void Main(string[] args)
        {
            #region Task1

            #region Employees

            var employee = new Employee()
            {
                Surname = "TestSurname",
                Middle = "TestMiddle",
                Name = "TestName",
                UserModel = new User()
                {
                    Login = "login1",
                    Password = "Qwerrty1",
                    Nick = "nick"
                }
            };

            var employee2 = new Employee()
            {
                Surname = "TestSurname2",
                Middle = "TestMiddle2",
                Name = "TestName2",
                UserModel = new User()
                {
                    Login = "login2",
                    Password = "Qwerrty1",
                    Nick = "nick2"
                }
            };
            
            var employee3 = new Employee()
            {
                Surname = "TestSurname3",
                Middle = "TestMiddle3",
                Name = "TestName3",
                UserModel = new User()
                {
                    Login = "login3",
                    Password = "Qwerrty3",
                    Nick = "nick3"
                }
            };

            #endregion

            #region Parking

            // парковка
            var parkingTechnics = new ParkingTechnics(new Transport[]
            {
                new FreightTransport()
                {
                    Model = "ModelTransport",
                    Name = "NameTransport",
                    Number = "2234-gh",
                    Year = 2012,
                    BusyBy = null
                },
                new Agricultural()
                {
                    Model = "ModelTransport2",
                    Name = "NameTransport2",
                    Number = "1134-gh",
                    Year = 1980,
                    BusyBy = null
                },
                new FreightTransport()
                {
                    Model = "ModelTransport3",
                    Name = "NameTransport3",
                    Number = "2565-gh",
                    Year = 2003,
                    BusyBy = null
                }
            });
            
            parkingTechnics.AddTransport(new Agricultural()
            {
                Model = "Model999",
                Name = "NameSuper",
                Number = "4500-po",
                BusyBy = null
            });
            
            // вывод транпорта
            parkingTechnics.PrintAll();

            // занимаем для сотрудников
            parkingTechnics.GetTransportFor(employee, "2234-gh");
            parkingTechnics.GetTransportFor(employee2);
            parkingTechnics.GetTransportFor(employee3);

            #endregion
            
            // организуем рабочий денёк)
            var workMachines = parkingTechnics.GetBusyTransport();
            var grain = new GrainHarvesting(workMachines);

            // приезд первой машины
            grain.AddTones("2234-gh", 10, DateTime.Now);
            // второй
            grain.AddTones(employee2, 11, DateTime.Now);
            // третьей
            grain.AddTones(employee3, 13, DateTime.Now);
            
            // спустя пол дня
            
            // приезд первой машины
            grain.AddTones("2234-gh", 13, DateTime.Now);
            // второй
            grain.AddTones(employee2, 7, DateTime.Now);
            // третьей
            grain.AddTones(employee3, 9, DateTime.Now);


            Console.WriteLine($"All tones: {grain.GetTotal()} tones");
            var bestModel = grain.GetBest();
            Console.WriteLine($"Best employee -- {bestModel.Transport.BusyBy.GetFullName()} -- {bestModel.Tones} tones");

            parkingTechnics.FreeTransport("2234-gh");
            
            var freeTransport = parkingTechnics.GetTransportByNumber("1134-gh");
            parkingTechnics.FreeTransport(freeTransport);

            var busyTransports = parkingTechnics.GetBusyTransport();
            parkingTechnics.FreeTransport(busyTransports.Select(x => x.Number).ToArray());


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