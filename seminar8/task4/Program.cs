/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] Matrix(int m, int n, int z)
{
    List<int> notUniqueElements = new List<int>();
    Random rand = new Random();
    int[,,] matrix = new int[m, n, z];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) 
        { 
            for (int k = 0; k < z; k++)
            {
                while (true)
                {
                    int tempElement = rand.Next(10, 100);
                    if (!notUniqueElements.Contains(tempElement))
                    {
                        matrix[i, j, k] = tempElement;
                        notUniqueElements.Add(tempElement);
                        break;    
                    }
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)    
            {
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
        
    }
}


System.Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = Matrix(m, n, z);
PrintMatrix(matrix);