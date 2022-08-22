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

/* string Method4(int count, string text)
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
Console.WriteLine(res); */


/* internal class Program
{
    private static void Main(string[] args)
    {
        //Вид 4. Через цикл for
        string Method4(int count, string text)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result = result + text;
            }
            return result;
        }
        string res = Method4(10, "q");
        Console.WriteLine(res);
    }
} */

// Вид 4. Цикл в цикле/ Таблица умножения


/* 
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
 */





// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

/* 

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгроде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//для обращения к строке или её содержимому, можно использовать:
//string s = "qwerty"
//            012345
//для получения конкретного символа, необходимо обратиться к нему так:
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[index: i] == oldValue) result = result + $"{newValue}";
        else result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, oldValue: " ", newValue: "|");
Console.WriteLine(newText);


Почему-то не работает.......
 */ 





// Сортировка массива от меньшего к большему

int[] arr = {1, 4, 5, 7, 6, 3, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i=0; i < count; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i=0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);