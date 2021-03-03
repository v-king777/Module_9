using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class NumberRead
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine("\nВведите '1' для сортировки А-Я, '2' для сортировки Я-А, '3' - для выхода");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2 && number != 3)
            {
                throw new FormatException();
            }

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
