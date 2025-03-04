namespace task_11_08
{
    internal class Program
    {
        /*Использование params и out: Напишите метод, который принимает переменное 
         * количество чисел и возвращает их сумму и максимальное значение через выходные параметры (out).*/
        static void Main(string[] args)
        {
            CalculateSumAndMax(out int totalSum, out int maximumValue, 4, 44, 444);
            Console.WriteLine($"Сумма: {totalSum}");
            Console.WriteLine($"Максимальное значение: {maximumValue}");
        }

        static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = numbers.Length > 0 ? numbers[0] : 0; 

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max) max = number;
            }
        }
    }
}
