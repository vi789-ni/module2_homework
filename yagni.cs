using System;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void SaveToDatabase()
    {
        Console.WriteLine($"Пользователь {Name} сохранен в базу.");
    }
}

public class FileReader
{
    public string ReadFile(string filePath)
    {
        return $"Содержимое файла {filePath}";
    }
}

public class ReportGenerator
{
    public void GenerateReport(string format)
    {
        Console.WriteLine($"Отчет в формате {format} сгенерирован.");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите имя пользователя: ");
        string name = Console.ReadLine();
        Console.Write("Введите email пользователя: ");
        string email = Console.ReadLine();

        User user = new User { Name = name, Email = email };
        user.SaveToDatabase();

        Console.Write("\nВведите путь к файлу: ");
        string path = Console.ReadLine();
        FileReader reader = new FileReader();
        Console.WriteLine(reader.ReadFile(path));

        Console.Write("\nВведите формат отчета (PDF/Excel/HTML): ");
        string format = Console.ReadLine();
        ReportGenerator generator = new ReportGenerator();
        generator.GenerateReport(format);
    }
}
