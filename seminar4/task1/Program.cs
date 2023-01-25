/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Вариант 1

void Exponentiation()
{
    try
    {
        System.Console.Write($"Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result_number = num1;
        for (int i = 2; i <= num2; i++)
        {
            result_number *= num1;
        }
        System.Console.WriteLine(result_number);
    }
    catch
    {
        System.Console.WriteLine("Вы должны ввести натуральные числа!");
    }
}


Exponentiation();


// Вариант 2
/*
int Exponentiation()
{
    int number1 = 1;
    int number2 = 1;
    while(true)
    {
        System.Console.Write($"Введите первое число: ");
        string? num1 = Console.ReadLine();
        System.Console.Write($"Введите второе число: ");
        string? num2 = Console.ReadLine();
        if (int.TryParse(num1, out number1))
        {
            if (int.TryParse(num2, out number2))
            {
                int result_number = number1;
                for (int i = 2; i <= number2; i++)
                {
                    result_number *= number1;
                }
                return result_number;
            }
            else
            {
                System.Console.WriteLine("Введено некорректное число. Попробуйте еще раз!");

            }
        }
        else
        {
            System.Console.WriteLine("Введено некорректное число. Попробуйте еще раз!");
        }

    }
}


int result_number = Exponentiation();
System.Console.WriteLine(result_number);
*/