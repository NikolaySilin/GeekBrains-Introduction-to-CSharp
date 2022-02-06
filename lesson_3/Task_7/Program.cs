//Выяснить является ли число чётным

System.Console.WriteLine("Введите число: ");

string digit = Console.ReadLine();

int digitInt = Int32.Parse(digit);

if(digitInt % 2 == 0)
{
    System.Console.WriteLine($"Число {digitInt} четное");
}
else
{
    System.Console.WriteLine($"Число {digitInt} не четное");
}