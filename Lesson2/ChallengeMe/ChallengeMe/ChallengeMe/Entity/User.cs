namespace ChallengeMe.ChallengeMe.Entity
{
    public class User
    {
        private string Name { get; set; }
        private string Password { get; set; }
        public void RegisterUser(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public void GetUserName()
        {
            return Name;
        }

        public void GetUserPassword()
        {
            return Password;
        }
    }
}
