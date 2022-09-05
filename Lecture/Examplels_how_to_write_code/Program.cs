//Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

8 4 2 4
5 9 2 3
1 4 7 2
*/



//Простой рандомный массив
/*
int[,] array = new int[3,4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
        
    }
    Console.WriteLine();
}
*/


int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

int temp = 0;

for (int write = 0; write < arr.Length; write++) {
    for (int sort = 0; sort < arr.Length - 1; sort++) {
        if (arr[sort] > arr[sort + 1]) {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");

Console.ReadKey();