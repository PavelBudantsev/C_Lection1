Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "петя")
{
    Console.WriteLine("Ура! Петя, ты ли?!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}