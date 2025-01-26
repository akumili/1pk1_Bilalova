namespace task_04_08
{
    internal class Program
    {
        /*Дан массив, содержащий последовательность 50 случайных чисел.
         * Найти количество пар элементов, значениякоторых равны.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] massiv = new int[50];    
            for (int i = 0; i < massiv.Length; i++)
                massiv[i] = rnd.Next(0, 10);
            int count = 0;
            for (int i = 1; i < massiv.Length; i++)
                if (massiv[i - 1] == massiv[i])
                    count++;

            Console.WriteLine($" одинаковых пар элементов: {count} ");
        }
    }
}
