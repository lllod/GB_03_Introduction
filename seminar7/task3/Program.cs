/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Matrix(int m, int n)
{
    Random rand = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] Average(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            averageArray[i] += array[j, i];
        }
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
        averageArray[i] = Math.Round((averageArray[i] / array.GetLength(0)), 1);
    }
    return averageArray;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("Среднее арифметического каждого столбца: [" + string.Join(", ", arr) + "]");
}


System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintArray(Average(matrix));