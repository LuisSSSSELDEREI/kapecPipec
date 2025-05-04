using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            Console.WriteLine(); // Пустая строка для разделения таблиц для каждой цифры.
        }
    }
}
