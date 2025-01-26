﻿namespace task_04_10
{
    internal class Program
    { /*Заполнить массив из 10 элементов случайными числами в интервале [-10..10]
       * и сделать реверс элементов отдельно для 1-ой 
       * и 2-ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array использовать нельзя.
       * Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
       * Результат: [4,0,-10,2,5,-7,9,2,7,-6]*/
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
            Console.WriteLine("Изначальные элементы массива: ");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine("");
            for (int i = 0; i < array.Length / 4; i++)
            {
                int value = array[i];
                array[i] = array[array.Length / 2 - 1 - i];
                array[array.Length / 2 - 1 - i] = value;
            }
            for (int i = array.Length / 2; i < (int)(array.Length * 0.75); i++)
            {
                int value = array[i];
                array[i] = array[(int)(array.Length * 1.5) - 1 - i];
                array[(int)(array.Length * 1.5) - 1 - i] = value;
            }
            Console.WriteLine("Итоговые элементы массива: ");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine("");
        }
    }
}
