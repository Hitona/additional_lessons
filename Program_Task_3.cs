/*
Задача 3: Задайте произвольный массив.
Выведете его элементы, начиная с конца.
Использовать рекурсию, не использовать циклы.
*/

using System;

class Program
{
    static void PrintReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintReversed(array, index - 1);
        }
    }

    static void Main()
    {
        int[] array = new int[] {1, 2, 3, 4, 5};
        PrintReversed(array, array.Length - 1);
    }
}
