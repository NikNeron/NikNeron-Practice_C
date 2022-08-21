
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            452 -> 11
            82 -> 10
            9012 -> 12*/
Console.WriteLine("Введите число");
string number = Console.ReadLine();

int length = number.Length;
int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    int a;
    a = number[i] - '0';  // Данное преобразование из Char в int я нашел в интернете,  int.Parse и Convert.ToInt32 не помогли
                          //ОБЪЯСНИТЕ ПОЖАЛУЙСТА В ЧЕМ СМЫСЛ ТАКОГО ВАРИАНТА, ПОЧЕМУ ОН РАБОТАЕТ И КАКОЙ ЕСТЬ ДРУГОЙ ВАРИНТ ПРЕОБРАЗОВАНИЯ В РАМКАХ ЦИКЛА?
    sum += a;
}

Console.WriteLine(sum);