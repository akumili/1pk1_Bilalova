using System.ComponentModel.Design;

namespace task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
         * диагональной (все элементы вне главной диагонали равны нулю) 
         * Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси 
         * сообщение что матрица не является диагональной*/
        static void Main(string[] args)
        {

            Console.Write("Введите размер квадратного массива вида [n*n]: ");
            int n = int.Parse(Console.ReadLine());

            // создаем квадратный массив вида [n*n]
            int[,] array = new int[n, n];
            //заполняем массив рандомными числами
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 10);
                    Console.Write(array [i, j] + "\t");
                }
                     Console.WriteLine();
            }


            // анализ на диагональность
            bool isDiagonal = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && array[i, j] != 0)
                    {
                        isDiagonal = false;
                        break;
                    }
                }


                if (isDiagonal)

                    Console.WriteLine("\nМатрица диагональнаю");
                for (int f = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(array[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(array [i, j] + "\t");
                        }
                    }
             
                    
 
                    Console.WriteLine();
                }
            }  
                

                
            
        }
    }
}









