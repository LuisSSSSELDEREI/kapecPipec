using System;

public class DepositCalculatorWhile
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int numberOfMonths = Convert.ToInt32(Console.ReadLine());

        decimal currentAmount = depositAmount;
        int monthCounter = 0;

        while (monthCounter < numberOfMonths)
        {
            currentAmount += currentAmount * 0.07m; // 7% от текущей суммы
            monthCounter++;
        }

        Console.WriteLine("Конечная сумма вклада: " + currentAmount);
    }
}
