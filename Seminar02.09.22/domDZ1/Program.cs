/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/


int count = 0;
void Rip()
{
    Console.WriteLine("Введите число больше 0");
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    count = m; 
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Вы ввели неправельное число");
        Rip();
    }
    PrintCount(m, n);
}

void PrintCount(int m, int n)
{
    Console.Write(count + ", ");
    if (count < n)
    {
        count++;
        PrintCount(m, n);
    }
    if (count > n)
    {
        count--;
        PrintCount(m, n);
    }
}

Rip();