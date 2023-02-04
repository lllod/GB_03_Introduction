/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


// Вариант1
/*
int IntegerNumber()
{
    int integerNumber = 0;
    while (true)
    {
        System.Console.Write("Введите целое число (для выхода из программы введите q): ");
        string? num = Console.ReadLine();
        if (num == "q") return integerNumber;
        else if (Convert.ToInt32(num) > 0) integerNumber += 1;
    }
}


System.Console.WriteLine(IntegerNumber());
*/

// Вариант 2

int[] IntegerArray()
{
    var integerList = new List<int>();
    while (true)
    {
        try
        {
            System.Console.Write("Введите целое число (для выхода из программы введите q): ");
            string? num = Console.ReadLine();
            if (num == "q") break;
            integerList.Add(Convert.ToInt32(num));
        }
        catch
        {
            System.Console.WriteLine("Ошибка ввода. Вы ввели не целое число!");
        }
    }
    int[] integerArray = integerList.ToArray();
    return integerArray;
}

int NaturalNumbers(int[] arr)
{
    int naturalNumber = 0;
    foreach (int i in arr)
    {
        if (i > 0) naturalNumber += 1;
    }
    return naturalNumber;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int[] array = IntegerArray();
PrintArray(array);
System.Console.WriteLine($"Количество положительных чисел: {NaturalNumbers(array)}");