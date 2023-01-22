/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Вариант 1
/*
int[] coords = new int[6];
System.Console.Write("Введите координату X первой точки: ");
coords[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y первой точки: ");
coords[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z первой точки: ");
coords[2] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату X второй точки: ");
coords[3] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y второй точки: ");
coords[4] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z второй точки: ");
coords[5] = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((coords[3] - coords[0]), 2) + Math.Pow((coords[4] - coords[1]), 2) + Math.Pow((coords[5] - coords[2]), 2));
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToNegativeInfinity));
*/


// Вариант 2
/*
int[][] coords = new int[2][];
coords[0] = new int[3];
coords[1] = new int[3];
for (int i = 0; i < coords.Length; i++)
{
    for (int j = 0; j < coords[i].Length; j++)
    {
        System.Console.Write($"Введите {j + 1} координату точки {i + 1}: ");
        coords[i][j] = Convert.ToInt32(Console.ReadLine());

    }
}
double result = Math.Sqrt(Math.Pow((coords[1][0] - coords[0][0]), 2) + Math.Pow((coords[1][1] - coords[0][1]), 2) + Math.Pow((coords[1][2] - coords[0][2]), 2));
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToNegativeInfinity));
*/


// Вариант 3
/*
int[,] coords = new int[2, 3];
for (int i = 0; i < coords.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < coords.GetUpperBound(1) + 1; j++)
    {
        System.Console.Write($"Введите {j + 1} координату точки {i + 1}: ");
        coords[i, j] = Convert.ToInt32(Console.ReadLine());

    }
}
double result = Math.Sqrt(Math.Pow((coords[1, 0] - coords[0, 0]), 2) + Math.Pow((coords[1, 1] - coords[0, 1]), 2) + Math.Pow((coords[1, 2] - coords[0, 2]), 2));
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToNegativeInfinity));
*/

// Вариант 3.1
int[,] coords = new int[2, 3];
string[] symbols = {"X", "Y", "Z"};
for (int i = 0; i < coords.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < coords.GetUpperBound(1) + 1; j++)
    {
        System.Console.Write($"Введите {symbols[j]} координату точки {i + 1}: ");
        coords[i, j] = Convert.ToInt32(Console.ReadLine());

    }
}
double result = Math.Sqrt(Math.Pow((coords[1, 0] - coords[0, 0]), 2) + 
                          Math.Pow((coords[1, 1] - coords[0, 1]), 2) + 
                          Math.Pow((coords[1, 2] - coords[0, 2]), 2));
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToNegativeInfinity));