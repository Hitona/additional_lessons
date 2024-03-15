// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.Write("Введите текст для проверки: ");
string original = Console.ReadLine();
string reversed = new string(original.Reverse().ToArray());

if (original == reversed)
{
    Console.WriteLine("Введенная строка является палиндромом.");
}
else
{
    Console.WriteLine("Введенная строка не является палиндромом.");
}
