namespace task_20_05
{
    /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
• Guest (только чтение)
• User (чтение + комментарии)
• Moderator (удаление контента)
• Admin (полный доступ)
Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).
    На основе уровня доступа выводите сообщение (например,
"Ошибка: Недостаточно прав!").*/
    public enum AccessLevel
    {
        Guest,
        User,     
        Moderator, 
        Admin      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем пользователей
            (string Name, AccessLevel Level)[] users = new (string, AccessLevel)[]
            {
                ("Гость", AccessLevel.Guest),
                ("Пользователь", AccessLevel.User),
                ("Модератор", AccessLevel.Moderator),
                ("Администратор", AccessLevel.Admin)
            };

            // Создайте метод, который проверяет, может ли пользователь выполнить действие 
            foreach (var user in users)
            {
                CheckPermission(user.Name, user.Level, "удалить пост");
            }
        }

        static void CheckPermission(string name, AccessLevel level, string action)
        {
            if (CanPerformAction(level, action))
            {
                Console.WriteLine($"{name} может выполнить действие: {action}.");
            }
            else
            {
                Console.WriteLine($"Ошибка: {name}, недостаточно прав: {action}.");
            }
        }

        static bool CanPerformAction(AccessLevel level, string action)
        {
            // может ли пользователь выполнить действие (например, удалитьпост).
            if (action == "удалить пост")
            {
                return level == AccessLevel.Moderator || level == AccessLevel.Admin;
            }

            
            return false;
        }
    }
}
