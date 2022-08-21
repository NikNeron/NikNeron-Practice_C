/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

int a = 0;
int b = 0;
void Enter()
{
    Console.WriteLine("Enter the first number: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    b = int.Parse(Console.ReadLine());
}
double Pow(int a, int b)
{
    return Math.Pow(a, b);
}
for (int i = 0; i < 1; i++)
{
    Enter();
    Console.WriteLine(Pow(a, b));
}