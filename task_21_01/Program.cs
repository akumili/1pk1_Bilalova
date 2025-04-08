namespace task_21_01
{
    /*Дан список чисел. Создать новый список, содержащий только чётные числа из исходного списка, умноженныена10.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // новый список, содержащий только чётные числа из исходного списка, умноженныена10
            List<int> evenNumbersMultipliedByTen = numbers
                .Where(n => n % 2 == 0) // Фильтрация четных
                .Select(n => n * 10)    
                .ToList();              

            // итог
            Console.WriteLine("Исходный список: " + string.Join(", ", numbers));
            Console.WriteLine("Преобразованный список: " + string.Join(", ", evenNumbersMultipliedByTen));
        }
    }
}
