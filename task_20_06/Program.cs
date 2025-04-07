
namespace task_20_06
{
    /*Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
• Red
• Yellow
• Green
Реализуйте автоматическое переключение цветов (каждые 3 секунды).
    При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
    Добавьте возможность ручного переключения (например, по нажатию клавиши).*/
    public enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }
    internal class Program
    {
        private static TrafficLightColor currentColor = TrafficLightColor.Red; // изначальный цвет
        private static readonly object lockObj = new object();
        private static bool running = true; 

        static void Main(string[] args)
        {
            Console.WriteLine("Светофор запущен. выход - e (exit).");

            // автоматическое переключение цветов
            Thread trafficLightThread = new Thread(() =>
            {
                while (running)
                {
                    lock (lockObj)
                    {
                        Console.Clear();
                        Console.WriteLine($"Текущий цвет: {currentColor}");
                        currentColor = GetNextColor(currentColor);
                    }
                    Thread.Sleep(3000); // задержка 3 секунды
                }
            });

            trafficLightThread.Start();

            // Добавляем возможность ручного переключения
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.E)
                    {
                        running = false; 
                        break; 
                    }
                    else if (key == ConsoleKey.Spacebar)
                    {
                        lock (lockObj)
                        {
                            currentColor = GetNextColor(currentColor); // Ручное переключение цвета
                        }
                    }    }    }
        
            }    
private static TrafficLightColor GetNextColor(TrafficLightColor currentColor)
        {
            throw new NotImplementedException();
        }
    }
}


