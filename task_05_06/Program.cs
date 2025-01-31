namespace task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
          • 1 столбец содержит нули
          • 2 столбце содержит числа кратные 2
          • 3 столбец содержит числа кратные 3
          • 4 столбец содержит числа кратные 4
          • 5 столбец содержит числа кратные 5*/
        static void Main(string[] args)
        {

            int n = 10;
            int m = 5;


            int[,] array = new int[n, m];

            // относительно условия заполняем массив
            for (int i = 0; i < n; i++)
            {
                array[i, 0] = 0; 
                array[i, 1] = (i + 1) * 2; 
                array[i, 2] = (i + 1) * 3; 
                array[i, 3] = (i + 1) * 4; 
                array[i, 4] = (i + 1) * 5; 
            }

            // Выводим массив на экран
            Console.WriteLine("Итоговый массив:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    
        
    
}





