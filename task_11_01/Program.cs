namespace task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа 
         * и меняет их местами. Проверьте, изменились ли значения переменных вне метода*/
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 44;

            Console.WriteLine($"Значение до вызова метода: {num1},{num2}");

            Swap(num1, num2);

            Console.WriteLine($"Значение после: {num1},  {num2}");
        }

        static void Swap(int a, int k)
        {
            int f = a;
            a = k;
            k = f;

         
            Console.WriteLine($"Значение внутри метода:{a},{k}");

        }
    }
}
