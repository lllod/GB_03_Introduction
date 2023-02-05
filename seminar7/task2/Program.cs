/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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


string SearchElement(int[,] array)
{
    System.Console.Write("Введите номер строки искомого элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите номер столбца искомого элемента: ");
    int col = Convert.ToInt32(Console.ReadLine());
    if (row - 1 < array.GetLength(0) && col - 1 < array.GetLength(1))
    {
        return $"Элемент на позиции [{row}, {col}] в массиве: {array[row - 1, col - 1]}";    
    }
    return $"Позиции [{row}, {col}] в массиве не существует!";
}




System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine(SearchElement(matrix));