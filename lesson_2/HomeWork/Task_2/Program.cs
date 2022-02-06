// По двум заданным числам проверять является ли первое квадратом второго


System.Console.Write("Введите первое число: ");
string firstDigit = Console.ReadLine();
int firstDigitInt = Int32.Parse(firstDigit);

System.Console.Write("Введите второе число: ");
string secondDigit = Console.ReadLine();
int secondDigitInt = Int32.Parse(secondDigit);

if (firstDigitInt % secondDigitInt == 0)
{
    System.Console.WriteLine($"Число {firstDigit} является квадратом {secondDigit}");
}
else
{
    System.Console.WriteLine($"Число {firstDigit} не является квадратом {secondDigit}");
}
