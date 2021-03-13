using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var exceptions = new Exception[]
            {
                new ArgumentOutOfRangeException(),
                new DivideByZeroException(),
                new InvalidOperationException(),
                new TimeoutException(),
                new MyException("Произошла ужасная и непоправимая ошибка!")
            };

            foreach (var item in exceptions)
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
