

/*
Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
 
[1 2 3 4 5] -> [5 4 3 2 1]
 
[6 7 3 6] -> [6 3 7 6]
 

 */
/*

int[] FillArray(int capacity)
{
    int[] array = new int[capacity];
 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write(array[i] + " ");
    }
    return array;
}
 
 
void arrayReverse(int[] array)
{
    int size = array.Length;
 
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
}
 
int[] arr = FillArray(10);
Console.WriteLine();
arrayReverse(arr);
 
foreach (int item in arr)
{
    Console.Write(item + " ");
}
*/
/*
Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10
 
[1, -5, 8, 4, -9] -> 4.33
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/////////////////////
Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12*/


void PrintArray(int[,] array)      //bool fillArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            //if (fillArray)
                array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");

        }
    }
}

int[,] array = new int[3, 3];

PrintArray(array); //true);
