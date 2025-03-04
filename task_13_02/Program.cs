namespace task_13_02
{
    /*создать класс питомца
свойства:
кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
методы:
вывод информации об объекте
изменение значения веса животного
изменение отметки о состоянии здоровья
конструторы:
предусмотрите разные варианты инициализации объектов*/
    internal class Program
    {
        static void Main(string[] args)
       {
             public class Pet
             {
                         // Свойства
                     public string Name { get; set; } // Кличка
                    public string Species { get; set; } // Вид животного
                       public int Age { get; set; } // Возраст
                      public double Weight { get; set; } // Вес
                    public bool IsHealthy { get; set; } // Состояние здоровья (здоров/нездоров)

                     
                          public Pet()
                          {
                            Name = "Неизвестно";
                            Species = "Неизвестно";
                            Age = 0;
                                   Weight = 0.0;
                                 IsHealthy = true;
                          }

                      
                        public Pet(string name, string species, int age, double weight, bool isHealthy)
                        {
                           Name = name;
                          Species = species;
                             Age = age;
                          Weight = weight;
                                  IsHealthy = isHealthy;
                        }

           
                         public void DisplayInfo()
                         {
                            Console.WriteLine($"Кличка: {Name}");
                              Console.WriteLine($"Вид: {Species}");
                               Console.WriteLine($"Возраст: {Age} лет");
                              Console.WriteLine($"Вес: {Weight} кг");
                                  Console.WriteLine($"Состояние здоровья: {(IsHealthy ? "Здоров" : "Нездоров")}");
                              Console.WriteLine();
                         }

            
                          public void ChangeWeight(double newWeight)
                          {
                             if (newWeight < 0)
                             {
                                Console.WriteLine("Вес не может быть отрицательным.");
                                    return;
                             }

                                  Weight = newWeight;
                                  Console.WriteLine($"Вес питомца '{Name}' изменён на {Weight} кг.");
                          }

            
                              public void ChangeHealthStatus(bool isHealthy)
                              {
                                  IsHealthy = isHealthy;
                                   Console.WriteLine($"Состояние здоровья питомца '{Name}' изменено на {(IsHealthy ? "Здоров" : "Нездоров")}");
                              }
             }
    }

}

