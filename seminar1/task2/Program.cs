﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int third_number = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[3] {first_number, second_number, third_number};
if (first_number == second_number && first_number == third_number)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    System.Console.WriteLine($"max = {numbers.Max()}");
}