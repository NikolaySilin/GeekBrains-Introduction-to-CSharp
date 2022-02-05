
void Pause (string message) // описание подпрограммы (метода)
{
    System.Console.WriteLine(message);
    Console.ReadKey();
}

Pause("Press any Key..."); //вызов метода


int Sum(int a, int b)
{
    return a + b;
}

System.Console.WriteLine(Sum(5, 6)); 

bool OddOrEven(int a)
{
    if (a % 2 ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine(OddOrEven(15));