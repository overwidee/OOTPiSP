using System;

namespace example3.Models
{
    public class Employee
    {
        public Employee()
        {
            
        }

        public Employee(string surname, string name, string middle, DateTime date, User user, Transport transport)
        {
            Surname = surname;
            Name = name;
            Middle = middle;
            BirthDay = date;
            UserModel = user;
            EmployeeTransport = transport;
        }

        private string Surname { get; }
        private string Name { get; }
        private string Middle { get; }
        private DateTime BirthDay { get; }
        private User UserModel { get; }
        private Transport EmployeeTransport { get; }

        private double _countTones;

        public void AddTones(double tones)
        {
            _countTones += tones;
        }

        public double Tones => _countTones;
        
        public string GetTransport()
        {
            return $"Name: {EmployeeTransport.Name}\n" +
                   $"Number: {EmployeeTransport.Number}\n" +
                   $"Type: {EmployeeTransport.TransportType}";
        }

        public string GetFullName()
        {
            return $"{Surname} {Name} {Middle}";
        }

        public string GetUserNick()
        {
            return UserModel.Nick;
        }
    }
}