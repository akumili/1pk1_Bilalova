namespace task_04_06
{
    internal class Program
    { /*Заполнить массив случайными положительными и отрицательными числами 
       * таким образом, чтобы все числа по модулю были разными.
       * Это значит, что в массиве не может быть ни только двух равных чисел,
       * но не может быть двух равных по модулю. В полученном массиве найти наибольшее по модулю число.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];       
            int[] numbers1 = new int[10];     

            int RandomNumber = 0; 
            int i = 0;      
            while (i < numbers.Length)
            {
                RandomNumber = rnd.Next(-10, 11);
                numbers1[i] = Math.Abs(RandomNumber);
                numbers[i] = RandomNumber;
                i++;
            }
                   int NumberMax = 0;
            foreach (int j in numbers)
                if (Math.Abs(NumberMax) < Math.Abs(j))
                    NumberMax = j;
            Console.WriteLine($"наибольшее по модулю:{NumberMax} .");
        }
    }
}
