/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}


int[,] array1 = new int[3, 4];

PrintArray(array1);
Console.WriteLine();


for (int j = 0; j < array1.GetLength(1); j++)
{
    double sum = 0;
    double q = 0;

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        sum += array1[i, j];
    }
    q = sum / array1.GetLength(0);
    Console.WriteLine("В {0} колонке ср/ариф: {1}", j, Math.Round(q, 2));
}

int  g = 4;
