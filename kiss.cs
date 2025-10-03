using System;

class KISS
{
    public void ProcessNumbers(int[] numbers)
    {
        foreach (var n in numbers)
        {
            if (n > 0)
                Console.WriteLine(n);
        }
    }

    public void PrintPositiveNumbers(int[] numbers)
    {
        foreach (var n in numbers)
        {
            if (n > 0)
                Console.WriteLine(n);
        }
    }

    public int Divide(int a, int b)
    {
        if (b == 0) return 0;
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        KISS ex = new KISS();

        Console.Write("Введите числа через пробел: ");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("\nПоложительные числа:");
        ex.ProcessNumbers(nums);

        Console.WriteLine("\nДеление:");
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {ex.Divide(a, b)}");
    }
}
