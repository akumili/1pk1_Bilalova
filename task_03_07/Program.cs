namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = 9.8;
            double step = 0.5;
            double duration = 15.0;

            Console.WriteLine(                 "скорость свободно падающего тела      ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("               время     |     скорость     ");
            Console.WriteLine("                 c       |       м/с     ");
            Console.WriteLine("-----------------------------------------------------");

            for (double t = 0; t <= duration; t += step)
            {
                double v = g * t;
                Console.WriteLine($"  {t,20:F1}   |   {v,20:F1}  ");
            }

           
        }
    }
}



