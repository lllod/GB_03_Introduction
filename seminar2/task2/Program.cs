/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


// Вариант 1

/*System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result_number = 0;
if (number > 99)
{
    while (number > 99)
    {
        result_number = number % 10;
        number = number / 10;
    }
    System.Console.WriteLine(result_number);
}
else
{
    System.Console.Write("Третьей цифры нет");
}*/


// Вариант 2

System.Console.WriteLine("Введите число: ");
string user_number = Console.ReadLine();
if (user_number.Length >= 3)
{
    System.Console.WriteLine(user_number[2]);
}
else
{
    System.Console.Write("Третьей цифры нет");
}