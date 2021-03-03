using System;

namespace Task2
{
    class NumberRead
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine("Введите '1' для сортировки А-Я или '2' для сортировки Я-А, '3' - для выхода");

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
