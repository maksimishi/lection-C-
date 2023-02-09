Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "максим") 
{
    Console.WriteLine("Ура Это же Макс!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}