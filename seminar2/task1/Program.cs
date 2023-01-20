/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


// Вариант 1

/*System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    System.Console.WriteLine(number / 10 % 10);
}
else
{
    System.Console.Write("Вы ввели не трехзначное число ");
}*/


// Вариант 2

/*System.Console.Write("Введите трехзначное число: ");
string user_number = Console.ReadLine();
if (user_number.Length == 3)
{
    System.Console.WriteLine(user_number[1]);
}
else
{
    System.Console.Write("Вы ввели не трехзначное число");
}*/


// Вариант 3

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (number > 99 && number < 1000)
    {
        System.Console.WriteLine(number / 10 % 10);
        break;
    }
    else
    {
        System.Console.Write("Вы ввели не трехзначное число. Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
}