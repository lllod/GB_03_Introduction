/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Вариант 1

System.Console.Write("Введите пятизначное число: ");
string? user_number = Console.ReadLine();
if (user_number!.Length == 5)
{
    char[] user_number_reverse = user_number.ToCharArray();
    Array.Reverse(user_number_reverse);
    string number_reverse = new string(user_number_reverse);
    string result = (user_number == number_reverse) ? ("Число является палиндромом") : ("Число не является палиндромом");
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число!");
}


// Вариант 2
/*
System.Console.Write("Введите пятизначное число: ");
string? user_number = Console.ReadLine();
if (user_number!.Length == 5)
{
    string result = (user_number[0] == user_number[4] && user_number[1] == user_number[3]) ? ("Число является палиндромом") : ("Число не является палиндромом");
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число!");
}
*/

// Вариант 3 (любая длина)
/*
System.Console.Write("Введите число (текст): ");
string? user_number = Console.ReadLine();
char[] user_number_reverse = user_number.ToCharArray();
Array.Reverse(user_number_reverse);
string number_reverse = new string(user_number_reverse);
string result = (user_number.ToLower() == number_reverse.ToLower()) ? ("Текст является палиндромом") : ("Текст не является палиндромом");
System.Console.WriteLine(result);
*/