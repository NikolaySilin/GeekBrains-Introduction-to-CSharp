// Выяснить являются ли три числа сторонами треугольника

double a = 10, b = 4, c = 7;

bool IsTreug(double x, double y, double z)
{
    bool flag;
    flag = (a + b > c && a + c > b && b + c > a);
    return flag;
}

System.Console.WriteLine($"{a} {b} {c} - " + IsTreug(a, b, c));
gi