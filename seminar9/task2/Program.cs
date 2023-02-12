/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

// ------------
// int AckermannFunc(int m, int n)
// {
//     if (m == 0) { return n + 1; }
//     else if (n == 0) { return AckermannFunc(m - 1, 1); }
//     else { return AckermannFunc(m - 1, AckermannFunc(m, n - 1)); }
// }

// System.Console.WriteLine(AckermannFunc(3, 2));


// ------------
int AckermannFuncSecond(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) { n = 1; }
        else { n = AckermannFuncSecond(m, n - 1); }
        m -= 1;
    }
    return n + 1;
}


System.Console.WriteLine(AckermannFuncSecond(3, 2));