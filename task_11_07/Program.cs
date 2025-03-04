namespace task_11_07
{
    internal class Program
    {
        /*Передача массива по ссылке (ref): Напишите метод, который принимает массив целых
         * чисел по ссылке и изменяет его элементы, увеличивая каждый на 1.
         * Проверьте, изменился ли оригинальный массив вне метода.*/
        static void Main(string[] args)
        {
            int[] origArray = { 44, 4, 444, };

            Console.WriteLine("перед изменением:");
            Console.WriteLine(string.Join(", ", origArray));

            // Вызываем метод для изменения массива
            IncreaseArray(ref origArray);

            Console.WriteLine("Оригинальный массив после изменения:");
            Console.WriteLine(string.Join(", ", origArray));
        }
      static void IncreaseArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }


    }
}

