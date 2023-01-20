// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Вариант #1
// System.Console.Write("Введите первое число: ");
// int first_number = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int second_number = Convert.ToInt32(Console.ReadLine());
// if (first_number > second_number)
// {
//     System.Console.WriteLine($"max = {first_number}");
// }
// else if (second_number > first_number)
// {
//     System.Console.WriteLine($"max = {second_number}");
// }
// else
// {
//     System.Console.WriteLine("Числа равны");
// }


// Вариант #2
System.Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[2] {first_number, second_number};
if (first_number == second_number)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    System.Console.WriteLine($"max = {numbers.Max()}");
}