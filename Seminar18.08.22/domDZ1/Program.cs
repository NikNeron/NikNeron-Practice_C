/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int a = 2;
int b = 3;
double c = 0;

double bil(double a, double b)
{
    double c = 0;
    c = Math.Pow(a, b);      // Math.Pow(a, b) - Возводит в натуральную степень
    return c;
}

for (int i = 0; i < 1; i++)
{
    c = bil(a, b);
}

Console.WriteLine(c);