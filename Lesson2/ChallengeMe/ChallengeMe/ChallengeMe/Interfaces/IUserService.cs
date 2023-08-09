namespace ChallengeMe.ChallengeMe.Interfaces
{
    public interface IUserService
    {
        public void RegisterUser(string name, string password);
        public void LoginUser(string name, string password);
        public void LogOutUser(string name);
    }
}
