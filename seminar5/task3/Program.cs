/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


// Вариант 1
/*
double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 2);
    }
    return arr;
}

double MaxElement (double[] arr)
{
    double maximum = 0.0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (maximum < arr[i])
        {
            maximum = arr[i];
        }
    }
    return maximum;
}

double MinElement (double[] arr)
{
    double minimum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minimum > arr[i])
        {
            minimum = arr[i];
        }
    }
    return minimum;
}

double MinMaxDiff (double min, double max)
{
    double diff = 0.0;
    if (min < 0)
    {
        diff = max + min;
    }
    else
    {
        diff = max - min;
    }
    return diff;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}


double[] array = FillArrayWithRandomNumbers(10, -100, 100);
System.Console.Write("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine($"Минимальный элемент массива: {MinElement(array)}");
System.Console.WriteLine($"Максимальный элемент массива: {MaxElement(array)}");
System.Console.WriteLine($"Разница максимального и минимального элементов массива: {Math.Round(MinMaxDiff(MinElement(array), MaxElement(array)), 2)}");
*/


// Вариант 2

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 2);
    }
    return arr;
}

double DiffElements(double[] arr)
{
    double diffElements = 0.0;
    if (arr.Min() < 0) { diffElements = arr.Max() + arr.Min(); } else { diffElements = arr.Max() - arr.Min(); }
    return diffElements;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}


double[] array = FillArrayWithRandomNumbers(10, -100, 100);
System.Console.Write("Сгенерированный массив: ");
PrintArray(array);
System.Console.WriteLine($"Минимальный элемент массива: {array.Min()}");
System.Console.WriteLine($"Максимальный элемент массива: {array.Max()}");
System.Console.WriteLine($"Разница максимального и минимального элементов массива: {Math.Round(DiffElements(array), 2)}");