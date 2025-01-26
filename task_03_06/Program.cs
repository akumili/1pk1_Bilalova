namespace task_03_06
{
    internal class Program
    {
        /* Написать программу, 
         * которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.*/
        static void Main(string[] args)
        {
            double X;
            Console.WriteLine("\n            значения функции");
            Console.WriteLine("----------------------------------------------");



            for (X = -4; X < 4; X += 0.5) ;
            {
                double y = Math.Abs(X);
                Console.WriteLine($"{X,20:F1} | {y,20:F1}");
            }
        }



    }

}