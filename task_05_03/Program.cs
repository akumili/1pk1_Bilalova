namespace task_05_03
{
    internal class Program
    {
        /*Даны два массива, заполненные символами английского алфавита размером 3*3. 
         * Проверить, являются ли матрицы равными, если
         * да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех 
         * элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
        */
        static void Main(string[] args)
        {
            char[,] array1 = new char[3, 3];
            char[,] array2 = new char[3, 3];

            // Заполняем первый массив символами от 'A' до 'I'
            char[] enAlphabet = { 'f', 'h', 'h', 'f', 'c', 'h', 'w', 'g', 'k', 'm', 'g', 'z', 'a', 'f', 'j' };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = enAlphabet[i * 3 + j];
                }
            }

            
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = enAlphabet[rand.Next(0, enAlphabet.Length)];
                }
            }

            Console.WriteLine("Array 1:");
            PrintArray(array1);
            Console.WriteLine("Array 2:");
            PrintArray(array2);

         
        }

        static void PrintArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}