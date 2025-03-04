namespace task_11_05
{
    /*Комбинирование ref и out: Напишите метод, который принимает два числа по
     * ссылке (ref) и возвращает их сумму и произведение через выходные параметры (out).*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 44;

           
            int sum;
            int product;
            Calculate(ref a, ref b, out sum, out product);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
        }

       
        static void Calculate(ref int x, ref int y, out int sum, out int product)
        {
            // Вычисляем 
            sum = x + y;
            product = x * y;
        }
    }
}
