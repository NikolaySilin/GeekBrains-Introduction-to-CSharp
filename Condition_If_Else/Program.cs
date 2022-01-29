Console.Write("Введите имя пользователя: ");

string _username = Console.ReadLine();

if (_username.ToLower() == "маша")
{
    Console.WriteLine("Ура это же МАША!");
}
else
{
    Console.Write("Привет " + _username + "!");
}
  