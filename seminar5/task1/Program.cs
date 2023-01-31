/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// Вариант 1

/*
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int EvenNumbers(int[] arr)
{
    int countEven = 0;
    foreach (int i in arr)
    {
        if (i % 2 == 0)
        {
            countEven += 1;
        }
    }
    return countEven;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int[] array = FillArrayWithRandomNumbers(10, 100, 999);
System.Console.Write("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbers(array)}");
*/


// Вариант 2

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

int EvenNumbers(int[] arr)
{
    var countEven = arr.Where(i => i % 2 == 0).Select(i => i).ToList();
    return countEven.Count;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int[] array = FillArrayWithRandomNumbers(10, 100, 1000);
System.Console.Write("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbers(array)}");
