namespace task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает одномерный массив и число для поиска, верните индексискомогоэлемента в массиве.
         * Если элемента нет – верните индекс = -1*/
        static void Main(string[] args)
        {
            int[] array = { 64, 1, 4, 4444, 44, 444, 24, 54};
            int numberToFind = 4;

            int index = FindElementIndex(array, numberToFind);

            if (index != -1)
            {
                Console.WriteLine($"{numberToFind} найден по индексу {index}.");
            }
            else
            {
                Console.WriteLine($"{numberToFind}  в массиве не обнаружен.. .");
            }
        }

     
        static int FindElementIndex(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i; 
                }
            }
            return -1; // требуемое условие
        }
    }
    }
