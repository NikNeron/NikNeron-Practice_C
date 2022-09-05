/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/




int count = 0;
int sum = 0;
void Rip()
{
    Console.WriteLine("Введите число больше 0");
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());  
    count = m;
    sum = count;
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Вы ввели неправельное число");
        Rip();
        
    }
    PrintCount(m, n);
    Console.WriteLine($"Сумма элементов " +sum);
}

void PrintCount(int m, int n)
{
    Console.Write(count + ", ");
    if (count < n)
    {
        count++;
        sum += count;
        PrintCount(m, n);
    }
    if (count > n)
    {      
        count--;
        sum += count;       
        PrintCount(m, n);
    }
    
}

Rip();