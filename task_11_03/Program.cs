namespace task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): Напишите метод, который принимает строку
         * и возвращает через выходной параметр количество гласных и согласных букв в этой строке*/
        static void Main(string[] args)
        {
            string input = " подсчет гласных и согласных букв.";
            int glasnCount;
            int soglCount;

            CountLetters(input, out glasnCount, out soglCount);

            Console.WriteLine($"кол-во гласных: {glasnCount}");
            Console.WriteLine($"кол-во согласных: {soglCount}");
        }

        // подсчитаем количество гласных и согласных букв
        static void CountLetters(string input, out int glasn, out int sogl)
        {
            glasn = 0;
            sogl = 0;

            string glasnSet = "аеёиоуыэюя";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (IsVowel(c, glasnSet))
                    {
                        glasn++;
                    }
                    else
                    {
                        sogl++;
                    }
                }
            }
        }

        // проверяем
        static bool IsVowel(char c, string glasnSet)
        {
            return glasnSet.Contains(c);
        }
    }
}
