// Найти кубы чисел от 1 до N

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
        currentDigit = i * i * i;
        System.Console.WriteLine("Куб числа {0} равен {1}", i, currentDigit);
    }
}

Input(out _digit);
Output(_digit);