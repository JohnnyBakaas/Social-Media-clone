using Social_Media_clone.Model;

namespace Social_Media_clone
{
    internal class Program
    {
        static List<User> Users = new List<User>();
        static List<Posts> Posts = new List<Posts>();

        static void Main(string[] args)
        {
            GenerateUsers generateUsers = new GenerateUsers(Users);
            GeneratePosts generatePosts = new GeneratePosts(Posts);

            View Screen = new View(0, Users);
            Screen.ViewSelector();
        }
    }
}