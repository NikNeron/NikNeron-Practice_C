//  Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет


int num = new Random().Next(98,101);
           string str = num.ToString();
           int a = 3;
            if(str.Length < a)
             Console.WriteLine(str+" --> Третьей цифры нет");
            else
            Console.WriteLine(str+"  --> "+str[2]);





