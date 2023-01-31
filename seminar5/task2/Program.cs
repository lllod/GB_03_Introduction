/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
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

int SumElements(int[] arr)
{
    int sumElements = 0;
    for (int i = 0; i < arr.Length; i += 2) // (int i = 1; i < arr.Length; i += 2)
    {
        sumElements += arr[i];
    }
    return sumElements;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int[] array = FillArrayWithRandomNumbers(10, -100, 100);
System.Console.Write("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {SumElements(array)}");
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

int SumElements(int[] arr)
{
    var sumElements = arr.Where((i, index) => index % 2 == 0).Sum(); // (i, index) => index % 2 == 1
    return sumElements;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int[] array = FillArrayWithRandomNumbers(10, -100, 100);
System.Console.Write("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {SumElements(array)}");