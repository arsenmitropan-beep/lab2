using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Завдання 1: Малювання трикутника
        Console.Write("Введіть висоту трикутника: ");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // Завдання 2: Перевірка високосного року
        Console.Write("Введіть рік: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
        {
            Console.WriteLine("Рік " + year + " є високосним.");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine("Рік " + year + " НЕ є високосним.");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine("Рік " + year + " є високосним.");
        }
        else
        {
            HandleNonLeapYear(year);
            Console.WriteLine("Hello, World!");
        }
    }

    private static void HandleNonLeapYear(int year)
    {
        Console.WriteLine("Рік " + year + " НЕ є високосним.");
    }
}