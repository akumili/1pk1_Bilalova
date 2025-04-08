namespace task_24_06
{
    /*Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. ИспользуйтеStreamReader.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            int lineCount = CountLinesInFile(filePath);
            if (lineCount >= 0) 
            {
                Console.WriteLine($"Количество строк в файле: {lineCount}");
            }
            else
            {
                Console.WriteLine("Ошибка!"); 
            }
        }

        // Метод для подсчета строк в файле
        static int CountLinesInFile(string path)
        {
            try
            {
                
                using (StreamReader reader = new StreamReader(path))
                {
                    int lineCount = 0;
                    while (reader.ReadLine() != null) 
                    {
                        lineCount++; 
                    }
                    return lineCount; 
                }
            }
            catch
            {
                return -1;
            }
        }
    }
}
