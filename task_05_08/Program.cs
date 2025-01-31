namespace task_05_08
{
    internal class Program
    {
        /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
результирующий массив)
Вывести результирующий массив */
        static void Main(string[] args)
        {
            int mas = 10;

         
            int[,] array1 = new int[mas, mas]; // первый массив
            int[,] array2 = new int[mas, mas]; // второй
            int[,] res = new int[mas, mas]; // итоговый

            Random random = new Random();

          
            for (int i = 0; i < mas; i++)
            {
                for (int j = 0; j < mas; j++)
                {
                    array1[i, j] = random.Next(1, 10); 
                }
            }

           
            for (int i = 0; i < mas; i++)
            {
                for (int j = 0; j < mas; j++)
                {
                    array2[i, j] = random.Next(1, 10); 
                }
            }

            // выполнение условия
            for (int i = 0; i < mas; i++)
            {
                for (int j = 0; j < mas; j++)
                {
                    res[i, j] = array1[i, j] * array2[i, j];
                }
            }

            // вывод всех массивов
            Console.WriteLine("Первый массив:");
            PrintArray(array1);

            Console.WriteLine("Второй массив:");
            PrintArray(array2);

            Console.WriteLine("произведение:");
            PrintArray(res);
        }
        static void PrintArray(int[,] array)
        {
            int size = array.GetLength(0);
            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j <10; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
     
         
             }
        }
    }
   
        }
