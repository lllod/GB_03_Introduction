/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


double[] OutArray()
{
    double[] outArray = new double[4];
    string[] symbols = { "b1", "k1", "b2", "k2" };
    for (int i = 0; i < 4; i++)
    {
        System.Console.Write($"Введите значение {symbols[i]}: ");
        outArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return outArray;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double[] Intercept(double[] arr)
{
    double[] intercept = new double[2];
    intercept[0] = arr[1] * ((arr[2] - arr[0]) / (arr[1] - arr[3])) + arr[0];
    intercept[1] = arr[3] * ((arr[2] - arr[0]) / (arr[1] - arr[3])) + arr[2];
    return intercept;
}


double[] array = OutArray();
PrintArray(Intercept(array));



// double b1 = Convert.ToInt32(Console.ReadLine());
// double k1 = Convert.ToInt32(Console.ReadLine());
// double b2 = Convert.ToInt32(Console.ReadLine());
// double k2 = Convert.ToInt32(Console.ReadLine());
// double y1 = 0;
// double y2 = 0;
// y1 = k1 * ((b2 - b1) / (k1 - k2)) + b1;
// y2 = k2 * ((b2 - b1) / (k1 - k2)) + b2;
// System.Console.WriteLine(y1);
// System.Console.WriteLine(y2);
