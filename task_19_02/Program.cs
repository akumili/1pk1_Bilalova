namespace task_19_02
{
    /*2. Напишите программу, которая запрашивает у пользователя произвольный текст,
     * содержащий предложения (есть знаки препинания). программу после анализа выводит текст,
     * разделенный на части:
a)  По пробелам (отдельные слова построчно)
b)  По предложениям (отдельные предложения построчно)
(используйте метод Split())*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // запрашиваем у пользователя произвольный текст
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            // текст, разделенный на части по пробелам
            string[] textwithwords = inputText.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\n отдельные слова построчно:");
            foreach (string word in textwithwords)
            {
                Console.WriteLine(word);
            }

            // текст, разделенный на части по предложениям
            char[] sentenceDelimiters = new char[] { '.', '!', '?' };
            string[] sentences = inputText.Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries);

            // итог
            Console.WriteLine("\n отдельные предложения построчно:");
            foreach (string sentence in sentences)
            {
                string trimmedSentence = sentence.Trim();
                if (!string.IsNullOrEmpty(trimmedSentence))
                {
                    Console.WriteLine(trimmedSentence);
                }
            }
        }
    }
}
