// Алгоритм замены

int a = 4, b = 5;
double x = 4.4, y = 5.5;

#region Swap. версия 1.
/*
void Swap(ref int a,ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void SwapDouble(ref double a,ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}
*/
#endregion


// Обобщенный Swap(Generic Swap)
void Swap<T>(ref T a, ref T b) // Параметризированный тип
{
    T t = a;
    a = b;
    b = t;
}

Swap<int>(ref a,ref b);

System.Console.WriteLine($"a = {a}  b = {b}");

Swap<double>(ref x,ref y);

System.Console.WriteLine($"x = {x}  y = {y}");


