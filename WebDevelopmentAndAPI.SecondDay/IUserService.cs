namespace WebDevelopmentAndAPI.SecondDay
{
    public interface IUserService
    {
        List<User> LoadUsers();
        void AddUser(User user);
    }
}
