//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Вводим 3 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int Mnumber(int a, int b, int c)
{
int[] array = new int[3]{a, b, c};
int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
        count++; 
    }
  }
return count;
}

Console.Write($"{Mnumber(a,b,c)} Числa больше ноля");

