// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string original = "Hello World! This is C#.";
string lowerCase = original.ToLower();

Console.WriteLine(lowerCase); // Вывод: "hello, world! this is c#."
