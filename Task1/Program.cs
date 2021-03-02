using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] arrayOfExceptions = new Exception[5];

            arrayOfExceptions[0] = new ArgumentOutOfRangeException();
            arrayOfExceptions[1] = new DivideByZeroException();
            arrayOfExceptions[2] = new InvalidOperationException();
            arrayOfExceptions[3] = new TimeoutException();
            arrayOfExceptions[4] = new MyException("Произошла ужасная и непоправимая ошибка!");

            foreach (var item in arrayOfExceptions)
            {
                try
                {
                    throw item;
                }

                catch (Exception ex) when (ex is InvalidOperationException)
                {
                    Console.WriteLine("Вызов метода недопустим в текущем состоянии объекта!");
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex) when (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Аргумент находится за пределами диапазона допустимых значений!");
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex) when (ex is DivideByZeroException)
                {
                    Console.WriteLine("Знаменатель в операции деления или целого числа Decimal равен нулю!");
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex) when (ex is TimeoutException)
                {
                    Console.WriteLine("Срок действия интервала времени, выделенного для операции, истек!");
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex) when (ex is MyException)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .\n");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
