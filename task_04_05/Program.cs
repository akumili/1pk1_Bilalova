namespace Task_04_05
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] precs = new int[30];

            int decada1 = 0;     
            int decada2 = 0;     
            int decada3 = 0;     
            int max = 0;   
            int day = 0; 

            for (int i = 0; i < precs.Length; i++)
            {
                precs[i] = random.Next(0, 301);
                  if (i < 10)
                    decada1 += precs[i];
                else if (i >= 20)
                    decada3 += precs[i];
                else
                    decada2 += precs[i];
                if (max < precs[i])
                {
                    max = precs[i];
                    day = i;
                }

                
                if (precs[i] == 0)
                    Console.WriteLine($"{i + 1} день без осадков");
            }

            Console.WriteLine($"первая декада: {decada1}мм осадков, вторая: {decada2},третья: {decada3}.");
            Console.WriteLine($"{day} числа: {max}мм - самые сильные осадки.");
        }
    }
}
