using System;

namespace example3.Models
{
    public class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle { get; set; }
        public User UserModel { get; set; }

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