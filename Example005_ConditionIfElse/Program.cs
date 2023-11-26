Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "ирина")
{
    Console.WriteLine("Здравствуй, дорогая. Рада тебе!");
}
else
{
    Console.Write("Хай, ");
    Console.WriteLine(username);
}