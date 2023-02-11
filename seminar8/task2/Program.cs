/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] MinRowArray(int[,] matrix)
{
    int[] minRowArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int minRowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minRowSum += matrix[i, j];
        }
        minRowArray[i] = minRowSum;
    }
    return minRowArray;
}

int MinRowIndex(int[,] matrix)
{
    int[] minRowArray = MinRowArray(matrix);
    int minRowIndex = 0;
    int rowSum = minRowArray[0];
    for (int i = 0; i < minRowArray.Length; i++)
    {
        if (rowSum > minRowArray[i]) 
        {
            rowSum = minRowArray[i];
            minRowIndex = i;
        }
    }
    return minRowIndex + 1;
}


System.Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"В {MinRowIndex(matrix)} строке сумма элементов минимальна");