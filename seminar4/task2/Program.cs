/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


// Вариант 1
/*
int SumNumber()
{
    System.Console.Write("Введите число: ");
    string? number = Console.ReadLine();
    int result_number = 0;
    foreach (var i in number!)
    {
        result_number += int.Parse(i.ToString());
    }
    return result_number;
}


int sum_number = SumNumber();
System.Console.WriteLine(sum_number);
*/


// Вариант 1.1
/*
int SumNumber()
{
    while (true)
    {
        System.Console.Write("Введите число: ");
        string? number = Console.ReadLine();
        int result_number = 0, user_number;
        if (int.TryParse(number, out user_number))
        {
            foreach (var i in number!)
            {
                result_number += int.Parse(i.ToString());
            }
            return result_number;
        }
        else
        {
            System.Console.WriteLine("Введено некорректное число. Попробуйте еще раз!");
        }
    }
}


int sum_number = SumNumber();
System.Console.WriteLine(sum_number);
*/


// Вариант 2

int SumNumber()
{
    while (true)
    {
        System.Console.Write("Введите число: ");
        string? number = Console.ReadLine();
        int result_number = 0, user_number;
        if (int.TryParse(number, out user_number))
        {
            for (int i = 0; i < number.Length; i++)
            {
                result_number += user_number % 10;
                user_number /= 10;
            }
            return result_number;
        }
        else
        {
            System.Console.WriteLine("Введено некорректное число. Попробуйте еще раз!");
        }

    }
}

int sum_number = SumNumber();
System.Console.WriteLine(sum_number);