/* int[] array = {1, 2, 3, 4, 13, 32, 43, 59}; метод для массива с разными числами

int n = array.Length;
int find = 59;

int index = 0;

while(index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
    }

    //index = index + 1: = index++;
index++;
}
 */

int[] array = {1, 2, 3, 4, 59, 32, 43, 59};

int n = array.Length;
int find = 59;

int index = 0;

while(index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }

index++;
}