// Найти сумму чисел от 1 до А

int _digit;

void Input(out int digit)
{
    digit = 0;

    System.Console.Write("Введите число: ");
    digit = Int32.Parse(Console.ReadLine());
}

void Output(int digit)
{
    var currentDigit = 0;

    for (int i = 1; i < digit + 1; i++)    
    {
        currentDigit = currentDigit + i;
    }
    System.Console.WriteLine("Cумма чисел от 1 до {0} равна {1}", digit, currentDigit);
}

Input(out _digit);
Output(_digit);