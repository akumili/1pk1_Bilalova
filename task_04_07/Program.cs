namespace task_04_07
{
    internal class Program
    { /*В массиве на 30 элементов содержатся данные по росту учеников в классе. 
       * Рост мальчиков условно задан отрицательными значениями.
       * Вычислить и вывести количество мальчиков и девочек в классе и средний рост для
       * мальчиков и девочек. При выводе избавиться
       * от отрицательных значений.*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] hght = new int[30];
            int countBoy = 0;
            double summB = 0;// суммарный рост мальчиков
            int countGirl = 0;
            double summG = 0;// суммарный рост девочек

            for (int i = 0; i < hght.Length; i++)
            {
                hght[i] = rnd.Next(140, 180) * (rnd.Next(2) * 2 - 1); 

                
                if (hght[i] < 0)
                {
                    summB += Math.Abs(hght[i]);
                    countBoy++;
                }
                else
                {
                    summG += hght[i];
                    countGirl++;
                }
            }
            Console.WriteLine($"Количество девочек в классе: {countGirl},количество мальчиков в классе: {countBoy}.");
            Console.WriteLine("Средний рост девочек: {0:g6}, средний рост мальчиков: {1:g6}", summG / countGirl, summB / countBoy);
        }
    }
}
