Console.Write("Введите своё имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лев")
{
    Console.WriteLine("Ку-ку Лев");
}

else
{
    Console.Write("Приветики, ");
    Console.WriteLine(username);
}