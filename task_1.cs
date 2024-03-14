/ Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string userInput = Console.ReadLine();

            if (userInput == "q")
            {
                break;
            }
            else if (Int32.TryParse(userInput, out int num))
            {
                int digitSum = 0;
                foreach (char digit in userInput)
                {
                    digitSum += Int32.Parse(digit.ToString());
                }

                if (digitSum % 2 == 0)
                {
                    Console.WriteLine($"Сумма цифр числа {num} чётная. Завершение программы.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {num} нечётная. Продолжаем.");
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное значение. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }
}
