// Подсчитать сумму цифр в числе

int _digits = 0;

void Input(out int digits)
{
    System.Console.Write("Введите число: ");
    digits = Int32.Parse(Console.ReadLine());
}



void Solution(int digits)
{  
    var result = 0;
    System.Console.WriteLine("Число: {0}",digits);

    while(digits > 0)
    {
        result = result + digits % 10;
        digits = digits / 10;
    }
    System.Console.WriteLine("Сумма чисел: {0}", result);
}

Input(out _digits);

Solution(_digits);