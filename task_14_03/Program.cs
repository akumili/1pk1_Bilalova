namespace task_14_03
{
    public static class MathUtilities
    {
        // Статический метод для вычисления факториала
        public static long Factorial(int number)
        {
            // Проверка на неотрицательное число
            if (number < 0)
            {
                throw new ArgumentException("Факториал не определен для отрицательных чисел.");
            }

            long result = 1;

            // Вычисление факториала
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите неотрицательное целое число:");

          
            string input = Console.ReadLine();
            int number;

          
            if (int.TryParse(input, out number))
            {
                try
                {
                   
                    long factorial = MathUtilities.Factorial(number);
                    Console.WriteLine($"Факториал {number} = {factorial}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка.");
                }
            }
            else
            {
                Console.WriteLine("Ошибкa");
            }
        }
    }
}