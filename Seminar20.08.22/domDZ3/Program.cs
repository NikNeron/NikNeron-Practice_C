
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int Giga(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);     
    }

    int max = array[0];
    int min = array[0];
    int s = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
        Console.Write(array[i] + " ");
    }

    s = max - min;
    Console.WriteLine($" max:{max} min:{min} s:{s}");
    return s;
}

int[] array = new int[10];
Giga(array);
