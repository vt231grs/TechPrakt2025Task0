using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.Clear();
            Console.Write("Введіть перше число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Помилка! Введіть коректне число.");
                continue;
            }
            Console.Write("Введіть друге число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Помилка! Введіть коректне число.");
                continue;
            }

            double result = num1 + num2;

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("Натисніть будь-яку клавішу для продовження або ESC для виходу.");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
                break;

        }
    }
}