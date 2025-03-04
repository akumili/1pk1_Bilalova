namespace task_11_06
{
    internal class Program

    {
        /*Передача массива по значению: Напишите метод, который принимает массив 
         * целых чисел и изменяет его элементы, увеличивая каждый на 1.
         * Проверьте, изменился ли оригинальный массив вне метода.*/
        static void Main(string[] args)
        {
            int[] originalArray = { 4, 44, 444, };

            //  массив до изменения
            Console.WriteLine("до изменения:");
            PrintArray(originalArray);

            //  изменяем копию массива
            IncreaseArrayElements(originalArray);

            //  массив после изменения
            Console.WriteLine("после изменения:");
            PrintArray(originalArray);
        }

        //
        static void IncreaseArrayElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }

            
            Console.WriteLine("Измененние внутри:");
            PrintArray(array);
        }

        // выводим
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
    }



