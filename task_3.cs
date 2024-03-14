// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Исходный массив
        int[] array = new int[] {1, 2, 3, 4, 5};
        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

        // Переворачиваем массив
        array = array.Reverse().ToArray();
        Console.WriteLine("Перевёрнутый массив: " + string.Join(", ", array));
    }
}
