/*Задача 50.Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


int[,] array = new int[3, 4];
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();

    }
}
int pip = 0;
void Hit(int[,] array)
{
    Console.WriteLine("Введите число ");
    pip = Convert.ToInt32(Console.ReadLine());
    
    Print(array);
    Console.WriteLine();
    bool gil = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i, j] == pip)
            {
                Console.Write("Индекс " + i + "-" + j + ", ");
                gil = true;
            }

        }

    }
    if (!gil)
    {
        Console.Write("Такого элемента нет ");
        Hit(array);
    }   
}

Console.WriteLine();
Hit(array);