/*Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

int[,] array = new int[3, 4];

int Sum1(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
    int sum = (array[0, 0] + array[1, 1] + array[2, 2]);
    return sum;
}
int sum = Sum1(array); 
Console.WriteLine(sum);
