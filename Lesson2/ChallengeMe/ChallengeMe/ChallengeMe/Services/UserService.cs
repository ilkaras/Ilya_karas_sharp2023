using ChallengeMe.ChallengeMe.Entity;
using ChallengeMe.ChallengeMe.Interfaces;

namespace ChallengeMe.ChallengeMe.Services
{
    public class UserService : IUserService
    {
        private List<User> Users { get; set; }

        public void RegisterUser(string name, string password)
        {
            var user = new User(name, password);
            Users.Add(user);
            Console.WriteLine("Registration completed");
        }

        public void LoginUser(string name, string password)
        {
            var user = Users.Any(x => x.GetUserName() == name && x.GetUserPassword() == password);
            if (user)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Ooooops");
            }
        }
        public void LogOutUser(string name)
        {
            var user = Users.Any(x => x.GetUserName() == name);
            if (user)
            {
                Console.WriteLine("Bye");
            }
        }
    }
}
