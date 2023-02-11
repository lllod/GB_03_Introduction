/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] Matrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int i = 0, j = 0, indexElement = 1;
    for (int x = 0; x < n * n; x++)
    {
        int k = 0;
        for (k = 0; k < n - 1; k++)
        {
            matrix[i, j] = indexElement++;
            j += 1;
        }
        for (k = 0; k < n - 1; k++) 
        {
            matrix[i, j] = indexElement++;
            i += 1;
        }
        for (k = 0; k < n - 1; k++)
        {
            matrix[i, j] = indexElement++;
            j -= 1;
        }
        for (k = 0; k < n - 1; k++) 
        {
            matrix[i, j] = indexElement++;
            i -= 1;
        }
        i += 1;
        j += 1;
        if (n < 2) { n = 0; }
        else { n -= 2; }
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


int[,] matrix = Matrix(4, 4);
PrintMatrix(matrix);
System.Console.WriteLine();