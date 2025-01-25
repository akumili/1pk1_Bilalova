namespace task_02_02
{
    internal class Program
    {
        /* найти значение выражения при
            * при a = 8;b = 14;c = PI/4; 
            */
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double C = Math.PI;
            double part1 = Math.Pow(b + Math.Pow(a - 1, 3), 4);
            double part2 = Math.Abs(a - b) * (Math.Pow(Math.Sin(C), 2) + Math.Tan(C));
            double result = part1 / part2;
            Console.WriteLine(result);

        }
    }
}
