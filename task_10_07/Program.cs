namespace task_10_07
{
    internal class Program
    {
        /*Создайте метод с помощью которого можно сгенерировать и вернуть символьный 
         * двумерныймассив(состоящийиз символов русского алфавита) и выведите на консоль 
         * данный массив с помощью другого метода(который принимает данный массив в качестве параметра*/
        static void Main(string[] args)
        {
            int n = 4; // просвоим переменной цифру 4
            char[,] array = GenerateCharArray(n);
            PrintCharArray(array);
        }
        static char[,] GenerateCharArray(int n)
        {
       
            char[,] array = new char[n, n];//массив размером n*n

            
            char[] rusA = "ыщэюгъайжзлухпснетьдфяквиёбочмцрш".ToCharArray();
            Random random = new Random();

            //заполняем рандомом
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rusA[random.Next(rusA.Length)];
                }
            }

            return array;
        }

        static void PrintCharArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
