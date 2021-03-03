using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberRead numberRead = new NumberRead();
            numberRead.NumberEnteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberRead.Read();
                }

                catch (FormatException)
                {
                    Console.WriteLine("\nВведено некорректное значение!");
                }
            }
        }

        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("\nВыполнена сортировка А-Я"); break;
                case 2: Console.WriteLine("\nВыполнена сортировка Я-А"); break;
                case 3: Environment.Exit(0); break;
            }
        }
    }
}
