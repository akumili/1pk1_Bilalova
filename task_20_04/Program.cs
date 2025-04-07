namespace task_20_04
{
    /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
• Car
• Bike
• Bus
• Truck
• Motorcycle
Храните список транспортных средств (можно просто List<VehicleType>). 
    Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков).
    Реализуйте поиск по типу и вывод информации.*/
    public enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // транспортные средства
            (VehicleType Type, string Model)[] vehicles = new (VehicleType, string)[]
            {
                 (VehicleType.Car, "Ford Focus"),
                (VehicleType.Bike, "Kawasakiii Ninja1"),
                   (VehicleType.Bike, "Kawasakiii Ninja2"),
                      (VehicleType.Bike, "Kawasakiii Ninja3"),
                (VehicleType.Bus, "Volvo 888"),
                (VehicleType.Truck, "Ram 444"),
                (VehicleType.Motorcycle, "Bucati Monster"),
                (VehicleType.Truck, "GMC Siera"),
                (VehicleType.Car, "Mazda 333")
            };

            // метод для подсчёта транспорта определённого типа (например, сколько грузовиков)
            Console.WriteLine("Введите тип транспортного средства для подсчета (Car, Bike, Bus, Truck, Motorcycle):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out VehicleType vehicleType))
            {
                int count = 0;

                // вывод инфы
                Console.WriteLine($"Список транспорта типа {vehicleType}:");
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Type == vehicleType)
                    {
                        Console.WriteLine($"{vehicle.Type}: {vehicle.Model}");
                        count++;
                    }
                }

                Console.WriteLine($"Количество транспорта типа {vehicleType}: {count}");
            }
            else
            {
                Console.WriteLine("Неправильный тип транспорта.");
            }
        }
    }
}
