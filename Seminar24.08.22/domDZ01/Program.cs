/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/



double[,] array = new double[3, 4];

double m = array.GetLength(0);
double n = array.GetLength(1);

void Hik(double[,] array)
{
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10 -5, 1);
            
           Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}
Hik(array);
Console.WriteLine();