// Определить количество цифр в числе

string _digits;

void Input(out string digits)
{
    System.Console.Write("Введите любое число: ");
    digits = Console.ReadLine();
}

void Output(string digits)
{
    System.Console.WriteLine(digits.Length);
}

Input(out _digits);
Output(_digits);