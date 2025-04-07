namespace task_19_01
{
    /*1. Напишите программу, в которой пользователь вводит произвольный текст в консоли, 
     * после чего программа запрашивает подстроку для поиска. Если подстрока найдена - то программа
     * запрашивает текст для того чтобы заменить на него эту подстроку (столько раз, сколько раз подстрока встречена в тексте)
Пример:
Введите строку: "Привет, мир!"
Введите подстроку для поиска: "мир"
Введите подстроку для замены: "друг"
Результат: "Привет, друг!"*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // пользователь вводит произвольный текст в консоли
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            // программа запрашивает подстроку для поиска
            Console.WriteLine("Подстрока для поиска:");
            string searchSubstring = Console.ReadLine();
            if (inputText.Contains(searchSubstring))
            {
                // запрашивает текст для того чтобы заменить на него эту подстроку
                Console.WriteLine("Введите подстроку для замены:");
                string replacementSubstring = Console.ReadLine();

               // заменяем
                string resultText = inputText.Replace(searchSubstring, replacementSubstring);

               // если подстрока найдена
                Console.WriteLine("Результат: " + resultText);
            }
            else
            {
                // если подстрока не найдена
                Console.WriteLine("Подстрока не найдена в тексте.");

            }
        }
    }
}
