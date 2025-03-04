namespace task_13_03
{
    internal class Program
    {
        /*создайте класс автомобиля
свойства:
номер авто, марка, цвет, текущая скорость
методы:
езда (симитировать равномерное ускорение скорости автомобиля)
торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
конструторы
предусмотрите разные варианты инициализации объектов*/
       
        
        public class Car
        {
            // Свойства автомобиля
            public string LicensePlate { get; set; } // Номер автомобиля
            public string Brand { get; set; } // Марка
            public string Color { get; set; } // Цвет
            public double CurrentSpeed { get; private set; } // Текущая скорость

            private const double MaxSpeed = 200.0; // макс скорость

        
            public Car()
            {
                LicensePlate = "Неизвестно";
                Brand = "Неизвестно";
                Color = "Неизвестно";
                CurrentSpeed = 0.0;
            }

       
            public Car(string licensePlate, string brand, string color)
            {
                LicensePlate = licensePlate;
                Brand = brand;
                Color = color;
                CurrentSpeed = 0.0;
            }

         
            public void Accelerate(double increment)
            {
                if (CurrentSpeed + increment > MaxSpeed)
                {
                    Console.WriteLine($"Скорость превышает допустимую ({MaxSpeed} км/ч). Автомобиль остановлен.");
                    CurrentSpeed = 0.0; // Остановка автомобиля при превышении скорости
                }
                else
                {
                    CurrentSpeed += increment;
                    Console.WriteLine($"Автомобиль '{Brand}' ускоряется до {CurrentSpeed} км/ч.");
                }
            }

          
            public void Brake()
            {
                if (CurrentSpeed > 0)
                {
                    Console.WriteLine($"Автомобиль '{Brand}' тормозит.");
                    CurrentSpeed = 0.0; // Остановка автомобиля
                    Console.WriteLine("Автомобиль остановлен.");
                }
                else
                {
                    Console.WriteLine("Автомобиль уже остановлен.");
                }
            }

           
            public void DisplayInfo()
            {
                Console.WriteLine($"Номер: {LicensePlate}");
                Console.WriteLine($"Марка: {Brand}");
                Console.WriteLine($"Цвет: {Color}");
                Console.WriteLine($"Текущая скорость: {CurrentSpeed} км/ч");
                Console.WriteLine();
            }
    }
}
}
