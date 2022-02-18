// Программа проверяет пятизначное число на палиндромом

int _digits;
bool _result;

void Input(out int digits)
{
    System.Console.Write("Введите пятизначное число: ");
    digits = Int32.Parse(Console.ReadLine());
}

void IsPalindrome(int digits,out bool result)
{
    result = false;
     int reversedDigits = 0;    
     int originalDigits = digits;

     while (digits > 0)
     {
         var currentDigit = digits % 10;
         reversedDigits = reversedDigits * 10 + currentDigit;
         digits /= 10;
     }
     
     if(reversedDigits == originalDigits)
     {
         result = true;
     }
}

void Output(int digits, bool result)
{
    if(result)
    {
        System.Console.WriteLine("Число {0} является полиндромом", digits);
    }
    else
    {
        System.Console.WriteLine("Число {0} не является полиндромом", digits);
    }
}

Input(out _digits);
IsPalindrome(_digits, out _result);
Output(_digits, _result);
