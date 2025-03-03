namespace task_10_06
{
    internal class Program
    {
        /*Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n,
         * выводит наконсольсгенерированный массив размерности n*n.*/
        static void Main(string[] args)
        {
            int n = 4; // просвоим переменной цифру 4
            ArrayGeneration(n);
        }

        static void ArrayGeneration(int n)
        {
           
            int[,] array = new int[n, n]; //  массив размером n*n
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 45); //заполняем рандом числами от 1 до 44
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine(); 
            }
        }
    }
}
