/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


// Вариант 1
/*
int[] RandomArray(int max_index, int min_number, int max_number)
{
    Random rand = new Random();
    int[] array = new int [max_index];
    for (int i = 0; i < max_index; i++)
    {
        array[i] = rand.Next(min_number, max_number);
    }
    return array;    
}


System.Console.Write("Введите количество элементов в массиве: ");
int max_index = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите минимальное значение элемента в массиве: ");
int min_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение элемента в массиве: ");
int max_number = Convert.ToInt32(Console.ReadLine());
int[] user_array = RandomArray(max_index, min_number, max_number);
System.Console.WriteLine($"[{string.Join(", ", user_array)}]");
*/


// Вариант 1.1

void RandomArray()
{
    while (true)
    {
        try
        {
            System.Console.Write("Введите количество элементов в массиве: ");
            int max_index = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Введите минимальное значение элемента в массиве: ");
            int min_number = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Введите максимальное значение элемента в массиве: ");
            int max_number = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] array = new int [max_index];
            for (int i = 0; i < max_index; i++)
            {
                array[i] = rand.Next(min_number, max_number);
            }
            System.Console.WriteLine($"[{string.Join(", ", array)}]");
            break;
        }
        catch
        {
            System.Console.WriteLine("Вы должны ввести натуральные числа!");
        }
    }
}


RandomArray();