namespace example3.Models
{
    public class User
    {
        public User()
        {
            
        }

        public User(string login, string password, string nick)
        {
            Login = login;
            Password = password;
            Nick = nick;
        }

        private string Login { get; }
        private string Password { get; }
        public string Nick { get; }
    }
}