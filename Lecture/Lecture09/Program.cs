
void PrintArray(int[,] array, bool fillArray)
    {
            for (int i = 0; i < array.GetLength(0); i++)
            {
             for (int  j = 0; j < array.GetLength(1); j++)
             {
               if(fillArray)
                array[i,j] = new Random().Next(1,10);
                Console.Write(array[i,j]+" ");
             }
             Console.WriteLine();
            }
    }
        Console.WriteLine("Введите значение для квадратной матрицы ");   // получилось только для квадратной - Как сделать сортировку  для  любой матрицы
        int x = int.Parse(Console.ReadLine());
        int[,] array = new int[x,x];
        PrintArray(array, true);

        int[,] b = new int[x, x];
        int[] temp = new int[x];

        Console.WriteLine("\nСортировка по строкам: ");
        for (int i = 0; i < x; i++)
        {
          for (int j = 0; j < x; j++)
                temp[j] = array[i, j];

            Array.Sort(temp);
              Array.Reverse(temp);
            for (int k = 0; k < x; k++)
            {
                array[i, k] = temp[k];
            }
        }

        PrintArray(array, false);

      


