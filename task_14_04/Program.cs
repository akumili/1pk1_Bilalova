namespace task_14_04
{

    /*Определите класс User, который будет иметь статическое свойство CurrentUser,
     * представляющеетекущегопользователя, и метод для его установки*/
    public class User
    {
      
        public static User CurrentUser { get; private set; }

        public string Name { get; set; }
        public string Email { get; set; }

      
        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }

    
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Email: {Email}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // новый пользователь
            User user1 = new User { Name = "Егор", Email = "egg@example.com" };

            
            User.SetCurrentUser(user1);

            // Проверяем
            if (User.CurrentUser != null)
            {
                Console.WriteLine("Текущий пользователь:");
                User.CurrentUser.DisplayInfo();
            }
            else
            {
                Console.WriteLine(" пользователь не установлен.");
            }
        }
    }
}