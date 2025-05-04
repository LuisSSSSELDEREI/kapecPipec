using System;

public class MultiplicationWithValidation
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите первое число (от 0 до 10):");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число (от 0 до 10):");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 < 0 || number1 > 10 || number2 < 0 || number2 > 10)
            {
                Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите числа от 0 до 10.");
            }
            else
            {
                Console.WriteLine($"Результат умножения: {number1 * number2}");
                break; // Выход из цикла, если числа в допустимом диапазоне
            }
        }
    }
}
