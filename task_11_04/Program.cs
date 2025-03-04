namespace task_11_04
{
    internal class Program
    {
        /*Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
         * их среднее значение. Используйте ключевое слово params*/
        static void Main(string[] args)
        {
            double av1 = CalculateAverage(4, 44, 444);
            Console.WriteLine($"Сред.знач {av1}");

            double av2 = CalculateAverage(10, 40, 400);
            Console.WriteLine($"Сред.знач: {av2}");

          
        }
        static double CalculateAverage(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            // Суммa
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (double)sum / numbers.Length;
        }
    }
}
