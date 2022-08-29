//Вид 1
/*
void Method1() // где Metod1, является идентификатором метода.

{
    System.Console.WriteLine("Автор...");
}
Method1();

//Вид 2
//Это метод, которые ничего не возвращают, но в то же время могут принимать какие-то аргументы.
void Method2(string msq)
{
    Console.WriteLine(msq);
}
Method2(msq: "Текст сообщения");

////////////////////////////////

void Method21(string msq, int msq)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msq);
        i++;
    }
}
//Method2(msq:"Текст", count: 4);      
Method21(count: 4, msq: "сообщения"); //  метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4.


// Вид 3
//Эти методы, которые что-то возвращают, но ничего не принимают. 


int Method3()   //не принимает никакие аргументы
{
    return DateTime.Now.Year;   //обязательное использование оператора return,
}

int year = Method3();  //вызываем метод
Console.WriteLine(year); //кладём нужное значение


// Вид 4
//Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают
//Возвращать будем строку string

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  //string result. Изначально можно и нужно в неё положит какое-то значение.

    while (i < count)
    {
        result = result + text;
        i++;              //Обязательно не забываем увеличивать счётчик и класть в result = result + text (это строчка, которую мы указали).
    }
    return result;
}

string res = Method4(10, " z");
Console.WriteLine(res);


//Цикл for

string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) //- вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);

//Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");  // -  это интерполяцию строк
    }
    Console.WriteLine();
}
*/
//////////////////////////////////////////////////////
//Тренировочная задача

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
             + "ежели бы вас послали вместо нашего милого Винценгероде,"
             + "вы бы взяли приступом согласие прусского короля."
             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// 012345   


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;  //Напоминаю, что инициализация пустой строки выглядит как string result = String.Empty
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
//string newText = Replace(text, " ", " - ");
//Console.WriteLine(newText);



