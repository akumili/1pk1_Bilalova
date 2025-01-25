using System.Data;

namespace task_02_04
{
    internal class Program
   {  
        /* Пользователь вводит свою дату рождения построчно 
         * (сначала год, потом месяц и в конце дату) 
         * произведите расчет является ли пользователь совершеннолетним
         * на текущую дату и выведите соответствующее 
         * сообщение об этом*/
   
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождения");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату рождения");
            int day = int.Parse(Console.ReadLine());

            int year1 = 2025 - year;
            int month1 = 1 - month;
            int day1 = 25 - day;
            if (year1 < 0)month1--;
            if (month1 < 0) year--;
            if (year1 >= 18)
                Console.WriteLine("Вы совершеннолетний");
            else Console.WriteLine("Вы несовершеннолетний");
        }
    }
}
