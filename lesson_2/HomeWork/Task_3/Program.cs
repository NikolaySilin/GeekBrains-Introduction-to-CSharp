// Даны два числа. Показать большее и меньшее число

System.Console.Write("Введите первое число: ");

string firstDigit = Console.ReadLine();
int firstDigitInt = Int32.Parse(firstDigit);

System.Console.Write("Введите второе число: ");

string secondDigit = Console.ReadLine();
int secondDigitInt = Int32.Parse(secondDigit);

if(firstDigitInt > secondDigitInt)
{
    System.Console.WriteLine($"Число {firstDigit} больше чем число {secondDigit}");
}
else if (firstDigitInt == secondDigitInt)
{
    System.Console.WriteLine($"Число {firstDigit} равно числу {secondDigit}");
}
else
{
    System.Console.WriteLine($"Число {firstDigit} меньше чем число {secondDigit}");
}
