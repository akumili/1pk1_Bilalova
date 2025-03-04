namespace task_11_02
{
    internal class Program
    {
        /*Передача по ссылке (ref): Напишите метод, который принимает два целых
         * числа по ссылке и меняет их местами. Проверьте, изменились ли значения переменных вне метода*/
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Значение до вызова метода:  {a},  {b}");

           
            Swap(ref a, ref b);

            Console.WriteLine($"После:  {a}, {b}");
        }

       
        static void Swap(ref int x, ref int y)
        {
            int temp = x; 
            // присваиваем значения переменным
            x = y;        
            y = temp;     
        }
    }
}
