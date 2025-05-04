using System;

public class DepositCalculatorFor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int numberOfMonths = Convert.ToInt32(Console.ReadLine());

        decimal currentAmount = depositAmount;

        for (int i = 0; i < numberOfMonths; i++)
        {
            currentAmount += currentAmount * 0.07m; // 7% от текущей суммы
        }

        Console.WriteLine("Конечная сумма вклада: " + currentAmount);
    }
}
