// По двум заданным числам проверять является ли одно квадратом другого

int _firstDigit = 0;
int _secondDigit = 0;
bool _result = false;

void Input(out int firstDigit,out int secondDigit)
{
    System.Console.Write("Введите первое число: ");
    firstDigit = Int32.Parse(Console.ReadLine());

    System.Console.Write("Введите второе число: ");
    secondDigit = Int32.Parse(Console.ReadLine());
}

bool CheckPower(bool result, int firstDigit, int secondDigit)
{
    if (firstDigit % secondDigit == 0)
    { 
        result = true;
    }
    return result;
}

void Output(bool result)
{
    if (result)
    {
        System.Console.WriteLine("Число {0} является квадратом числа {1}", _firstDigit, _secondDigit);
    }
    else
    {
        System.Console.WriteLine("Число {0} не является квадратом числа {1}", _firstDigit, _secondDigit);
    }
}

Input(out _firstDigit,out _secondDigit);
CheckPower(_result, _firstDigit, _secondDigit);
Output(_result);