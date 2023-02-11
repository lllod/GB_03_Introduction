/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] Matrix(int m, int n)
{
    Random rand = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) { matrix[i, j] = rand.Next(1, 10); }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] matrix)
{
    int maxRowElement = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (maxRowElement < matrix[i, j]) { maxRowElement = matrix[i, j]; }
        }
        int[] tempArray = new int[maxRowElement + 1];
        for (int j = 0; j < matrix.GetLength(1); j++) { tempArray[matrix[i, j]] += 1; }
        int indexSortArray = 0;
        for (int k = tempArray.Length - 1; k >= 0; k--)
        {
            for (int x = 0; x < tempArray[k]; x++)
            {
                matrix[i, indexSortArray] = k;
                indexSortArray += 1;
            }
        }
    }
    return matrix;
}


System.Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(SortMatrix(matrix));