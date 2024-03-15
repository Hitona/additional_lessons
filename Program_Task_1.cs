// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] array = new char[3, 3] 
{ 
    { 'a', 'b', 'c' }, 
    { 'd', 'e', 'f' }, 
    { 'g', 'h', 'i' } 
};

string result = "";
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
}

Console.WriteLine(result); // Вывод: "abcdefghi"
