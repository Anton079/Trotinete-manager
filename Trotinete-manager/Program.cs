using Trotinete_manager;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();

        User userNou = new User(5, "Ana@gmail.com", "fergrew", 0754645);

        userService.AddUser(userNou);

        userService.SaveData();
    }
}