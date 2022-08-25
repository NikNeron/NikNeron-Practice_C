// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


// 1 вариант

string str = "158";
Console.WriteLine(str[1]);

// 2 вариант
Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }




   