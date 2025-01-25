namespace task_03_05
{
    internal class Program
    {
        /*Написать программу, которая выводит на экран таблицу 
         * соответствия температуры в градусах Цельсия и
         * Фаренгейта (F = C*1,8 + 32).
         * Диапазон изменения температуры в градусах Цельсия 
         * и шаг должны вводиться во время работы программы*/
        static void Main(string[] args)
        {
       
                Console.Write("начальную температуру в Цельсиях: ");
                double cel = Convert.ToDouble(Console.ReadLine());
                Console.Write("конечная температура в Цельсиях: ");
                double cel2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("шаг изменения температуры: ");
                double step = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("\nТемпература в Цельсиях | Температура в Фаренгейтах");
                Console.WriteLine("----------------------------------------------");

                for (double cels = cel; cels <= cel2; cels += step)
                {
                    double fahrt = cels * 1.8 + 32;

                    Console.WriteLine($"{cels,20:F1} | {fahrt,20:F1}");
                }
            
        }

    }
}

