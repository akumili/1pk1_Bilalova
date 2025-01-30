namespace task_05_07
{
    internal class Program
    /*У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
числами в диапазоне от 10 до 99 включительно.
Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве*/
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите размерность n для квадратного массива n*n: ");
            int n = int.Parse(Console.ReadLine());

           
            int[,] matr = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = rand.Next(10, 100); 
                }
            }

            int min = matr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j] < min)
                    {
                        min = matr[i, j];
                    }
                }
            }

            Console.WriteLine($"Минимальный элемент в матрице: {min}");
              Console.WriteLine("Умноженная матрица:");

          
            
        }
    }
}
    

