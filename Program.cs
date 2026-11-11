namespace Завдання_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть висоту трикутника: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + "   ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
           
        }
    }
