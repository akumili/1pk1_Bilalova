namespace task_21_02
{
    /*Дан текст. Написать метод, который возвращает словарь, где ключ — слово, а значение —количествоеговхождений в тексте.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "массив - это простая и фундаментальная структура данных, в которой все элементы должны быть обязательногоодноготипа,располагаться в памяти последовательно друг за другом. размер массива фиксирован. при необходимости измененииразмера - массив перезаписывается";
            var wordCount = CountWordOccurrences(text);

            Console.WriteLine("Количество вхождений в тексте:");
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"Слово: '{pair.Key}', Количество: {pair.Value}");
            }
        }

        static Dictionary<string, int> CountWordOccurrences(string text)
        {
            // удаление знаков
            var words = text
                .Where(c => !char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                .Aggregate("", (current, c) => current + c)
                .ToLower()
                .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // словарь для хранения количества вхождений
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }
    }
}
