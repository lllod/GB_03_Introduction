/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


System.Console.Write("Введите число, обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    System.Console.WriteLine("Такого дня недели не существует");
}
else if (number == 7 || number == 6)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}