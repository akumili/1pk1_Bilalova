namespace task_23_06
{
    internal class Program
    {
        /*Напишите программу со следующими функциями:
1. Выведите информации о всех дисках в системе
2. Выведите содержимое каталога C:\Users (названия папок)
3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
a) Создание вложенного каталога “temp”
b) Вывод информации о текущем каталоге (имя, родитель и тд)
c) Вывод информации о вложенном каталоге
4. Переместите каталог “temp” по пути “D:\work\newTemp”
a) Реализуйте вывод информационного сообщения об успешном (или нет)
перемещении
5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
удалении.*/
        static void Main(string[] args)
        {
            // 1. Вывод информации о всех дисках в системе
            Console.WriteLine("Диски в системе:");
            foreach (var drive in DriveInfo.GetDrives())
            {
                Console.WriteLine($"{drive.Name} - {drive.DriveType}");
            }

            // 2. Вывод содержимого каталога C:\Users
            Console.WriteLine("\nСодержимое каталога C:\\Users:");
            string usersPath = @"C:\Users";
            foreach (var dir in Directory.GetDirectories(usersPath))
            {
                Console.WriteLine(Path.GetFileName(dir));
            }

            // 3. Создание на диске D папки “work”
            string workPath = @"D:\work";
            Directory.CreateDirectory(workPath);
            Console.WriteLine($"\nСоздан каталог: {workPath}");

            // a) Создание вложенного каталога “temp”
            string tempPath = Path.Combine(workPath, "temp");
            Directory.CreateDirectory(tempPath);
            Console.WriteLine($"Создан вложенный каталог: {tempPath}");

            // b) Вывод информации о текущем каталоге
            var currentDir = new DirectoryInfo(workPath);
            Console.WriteLine($"\nИнформация о текущем каталоге:");
            PrintDirectoryInfo(currentDir);

            // c) Вывод информации о вложенном каталоге
            var tempDir = new DirectoryInfo(tempPath);
            Console.WriteLine($"\nИнформация о вложенном каталоге 'temp':");
            PrintDirectoryInfo(tempDir);

            // 4. Перемещение каталога “temp” по пути “D:\work\newTemp”
            string newTempPath = Path.Combine(workPath, "newTemp");
            try
            {
                Directory.Move(tempPath, newTempPath);
                Console.WriteLine($"\n Успешное перемещение в: {newTempPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка!: {ex.Message}");
            }

            // 5. Удаление каталога “D:\work\newTemp”
            try
            {
                Directory.Delete(newTempPath, true); // Удаляем перемещенный каталог
                Console.WriteLine($"\nКаталог '{newTempPath}' успешно удален.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка!: {ex.Message}");
            }
        }

        static void PrintDirectoryInfo(DirectoryInfo dir)
        {
            Console.WriteLine($"Имя: {dir.Name}");
            Console.WriteLine($"Родитель: {dir.Parent?.Name}");
            Console.WriteLine($"Полный путь: {dir.FullName}");
        }
    }
}
