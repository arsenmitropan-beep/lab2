namespace Завдання_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                HandleNonLeapYear(year);
            Console.WriteLine("Hello, World!");
        }

        private static void (int year)
        {
            Console.WriteLine("Рік " + year + " НЕ є високосним.");
        }
    }
}
