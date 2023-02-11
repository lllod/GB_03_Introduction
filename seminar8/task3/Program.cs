/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] Matrix()
{
    System.Console.Write("Введите количество строк матрицы: ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов матрицы: ");
    int n = Convert.ToInt32(Console.ReadLine());
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

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] multMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int k = 0; k < secondMatrix.GetLength(1); k++)
        {
            int tempSum = 0;
            for (int j = 0; j < firstMatrix.GetLength(1); j++)
            {
                tempSum += firstMatrix[i, j] * secondMatrix[j, k];
            }
            multMatrix[i, k] = tempSum;
        }
    }
    return multMatrix;
}



System.Console.WriteLine("Введите параметры матриц. Внимание!\nКоличество столбцов первой матрицы должно совпадать с количеством строк второй матрицы.");
int[,] firstMatrix = Matrix(), secondMatrix = Matrix();
PrintMatrix(firstMatrix);
System.Console.WriteLine();
PrintMatrix(secondMatrix);
System.Console.WriteLine();
PrintMatrix(MultiplyMatrix(firstMatrix, secondMatrix));
