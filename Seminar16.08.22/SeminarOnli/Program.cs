/*Начиная с этого семинара обязательно используем функции в решении!

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/


/*int a = 2;
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

Console.WriteLine(c);*/

//double c = bil(5, 2);
//Console.WriteLine(c);

/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine("Введите число");
string number = Console.ReadLine();

int Sum(string number)
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        int a;
        a = number[i] - '0';  // Данное преобразование из Char в int я нашел в интернете,  int.Parse и Convert.ToInt32 не помогли
                              //ОБЪЯСНИТЕ ПОЖАЛУЙСТА В ЧЕМ СМЫСЛ ТАКОГО ВАРИАНТА, ПОЧЕМУ ОН РАБОТАЕТ И КАКОЙ ЕСТЬ ДРУГОЙ ВАРИАНТ ПРЕОБРАЗОВАНИЯ В РАМКАХ ЦИКЛА?
        sum += a;
    }
    return sum;

}
int sum = Sum(number); 
Console.WriteLine(sum);
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

void bil(int[] number)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
        Console.Write(array[i] + " ");
    }
}
bil(array);

*/

















