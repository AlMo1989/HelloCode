// Вид 1. Ничего не принимают и ничего не возвращают.
/* void Method1()
{
   Console.WriteLine("Author...");
}
Method1(); */ //вызов метода (идентификатор метода)


// Вид 2. Принимают, но не возвращают.
/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Message text");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        i++;
        Console.WriteLine(msg);
    }
}
//Method21("Text", 4);
Method21(count: 4, msg: "New txt"); */



// Вид 3. Возвращающие, но не принимающие

/* int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year); */



//Вид 4. Принимающие и возвращающие методы

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //или string result = ""; тоже самое, что string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "q");
Console.WriteLine(res);