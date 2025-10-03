using System;

public class Logger
{
    public void Log(string level, string message)
    {
        Console.WriteLine($"{level.ToUpper()}: {message}");
    }
}

public class Config
{
    public static string ConnectionString = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
}

public class DatabaseService
{
    public void Connect()
    {
        Console.WriteLine("Connecting to DB with: " + Config.ConnectionString);
    }
}

public class LoggingService
{
    public void Log(string message)
    {
        Console.WriteLine("Saving log to DB with: " + Config.ConnectionString);
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main()
    {
        Logger logger = new Logger();
        Console.Write("Введите сообщение для ошибки: ");
        string error = Console.ReadLine();
        logger.Log("error", error);

        Console.Write("Введите сообщение для предупреждения: ");
        string warn = Console.ReadLine();
        logger.Log("warning", warn);

        DatabaseService db = new DatabaseService();
        db.Connect();

        LoggingService logService = new LoggingService();
        Console.Write("Введите лог для записи в БД: ");
        string logMsg = Console.ReadLine();
        logService.Log(logMsg);
    }
}
