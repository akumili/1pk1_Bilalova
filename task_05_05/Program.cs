namespace task_05_05
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
      случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
      по следующему правилу:
      • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
      • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом*/
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            // обозначаем массив и заполняем рандомными числами
            int[,] array = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-99, 100); // берем числа в диапазоне от -99 до 99
                }
            }



            
            Console.WriteLine("\nИзмененный массив:");
            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < m; j++)


                {
                    if (array[i, j] < 0)
                    {
                        // выделение цветом относительно выполнения условия(Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым
                        // • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом)

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(array[i, j]) + "\t");
                        Console.ResetColor();
                    }
                    else if (array[i, j] == 0)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(1 + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        // 
                        Console.Write(array[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
