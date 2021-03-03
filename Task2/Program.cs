using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Program
    {
        static List<Human> oldList = GetListOfHumans();

        static void Main(string[] args)
        {
            NumberRead numberRead = new NumberRead();
            numberRead.NumberEnteredEvent += Sorting;
            
            ShowListOfHumans(oldList);

            while (true)
            {
                try
                {
                    numberRead.Read();
                }

                catch (FormatException)
                {
                    Console.WriteLine($"\nВведено некорректное значение!\n");
                }
            }
        }

        static void Sorting(int number)
        {
            switch (number)
            {
                case 1:
                    ShowListOfHumans(SortByA_Z(oldList));
                    Console.WriteLine("\nВыполнена сортировка от А до Я\n");
                    break;

                case 2:
                    ShowListOfHumans(SortByZ_A(oldList));
                    Console.WriteLine("\nВыполнена сортировка от Я до А\n"); 
                    break;

                case 3:
                    Environment.Exit(0); 
                    break;
            }
        }

        static List<Human> GetListOfHumans()
        {
            List<Human> humans = new List<Human>();

            humans.Add(new Human() { Surname = "Иванов" });
            humans.Add(new Human() { Surname = "Петров" });
            humans.Add(new Human() { Surname = "Сидоров" });
            humans.Add(new Human() { Surname = "Зайцев" });
            humans.Add(new Human() { Surname = "Волков" });

            return humans;
        }

        static List<Human> SortByA_Z(List<Human> list)
        {
            list.Sort(delegate (Human human1, Human human2)
            {
                return human1.Surname.CompareTo(human2.Surname);
            });

            return list;
        }

        static List<Human> SortByZ_A(List<Human> list)
        {
            list.Sort(delegate (Human human1, Human human2)
            {
                return human2.Surname.CompareTo(human1.Surname);
            });

            return list;
        }

        static void ShowListOfHumans(List<Human> list)
        {
            Console.WriteLine("\nСписок фамилий:\n");

            foreach (var item in list)
            {
                Console.WriteLine(item.Surname);
            }
        }
    }
}
