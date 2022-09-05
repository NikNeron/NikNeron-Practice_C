
// Метод 1
// Метод не принимает никаких аргументов и ничего не возвращают.

void Method1() //начало метода, Metod1 является идентификатором метода.
{
    Console.WriteLine("текст...");
}
Method1(); //вызов метода


//Метод 2
//принимает какие-то аргументы, но ничего не возвращают

void Metod2(string msg) //— где void ключевое слово, дальше идентификатор, в скобках
                        //указаны какие-то аргументы.
{
    Console.WriteLine(msg); // — оператор, в скобках указан принятый аргумент.
}
Metod2("Текст сообщения"); //— где Metod2 является идентификатором, а в скобках
                           //указан текст, выводимый в консоли.


/////  ИМЕНОВАННЫЕ АРГУМЕНТЫ
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);

//Метод 3
//КОТОРЫЙ ВОЗВРАЩАЕТ НО НИЧЕГО НЕ ПРИНЕМАЮТ

int Method3() //- не принимает никакие аргументы
{
    return DateTime.Now.Year; //обязательное использование оператора return,
}

int year = Method3();  //вызываем метод, в левой части используем идентификатор
//переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);


//Метод 4
// САМАЯ ВАЖНАЯ ГРУППА МЕТОДОВ

string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  // String.Empty - это пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "КУ ");
Console.WriteLine(res);


//Цикл for
/*
string Metod4(int count, string text)
{
    
    string result = String.Empty;  // String.Empty - это пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "КУ ");
Console.WriteLine(res);
*/

// Цикл внутри цикла

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
