
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int Figaro(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
        if (array[i] % 2 != 0)
        {
            sum += array[i];
        }
        Console.Write(array[i] + " ");
    }

    return sum;
}

int[] array = new int[10];
int a = Figaro (array);
Console.WriteLine("-> " +a);
