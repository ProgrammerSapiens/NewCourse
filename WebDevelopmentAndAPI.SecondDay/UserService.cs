using System.Text.Json;

namespace WebDevelopmentAndAPI.SecondDay
{
    public class UserService
    {
        private readonly string filePath;

        public UserService(IWebHostEnvironment env)
        {
            filePath = Path.Combine(env.ContentRootPath, "users.json");
        }

        public List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
                return new List<User>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public void AddUser(User user)
        {
            var users = LoadUsers();
            users.Add(user);

            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
