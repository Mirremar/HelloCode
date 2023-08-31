// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string Username = Console.ReadLine();
if(Username.ToLower() == "маша")
{
    Console.WriteLine("Ура,это же Маша!");
}
else
{
    Console.WriteLine("Привет, " + Username);    
}
