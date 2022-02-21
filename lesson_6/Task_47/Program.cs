// Написать программу мастабирования фигуры

// Треугольник

struct Point
{
    // ООП - Икапсуляция
    public int x, y;

    public string name = "no name";
    public void Print()
    {
        System.Console.WriteLine($"{name}) x = {x} / y = {y}");
    }
}

class Program
{
    static void Scale(int k,ref Point a,ref Point b,ref Point c)
    {
        a.x = a.x * k;
        a.y = a.y * k;
        b.x *= k;
        b.y *= k;
        c.y *= k;
        c.x *= k;

    }

    static void Main()
    {
        Point a;
        Point b;
        Point c;

        a.x = 0; a.y = 2; a.name = "a";
        b.x = 1; b.y = 4; b.name = "b";
        c.x = 3; c.y = 10; c.name = "c";

        a.Print();
        b.Print();
        c.Print();

        Scale(2, ref a , ref b, ref c);
        System.Console.WriteLine();

        a.Print();
        b.Print();
        c.Print();
    }
}

/*
static void ScaleAll(int k, Point[] arr)
{
    for (int i = 0; i < arr.Length; i++)
}
*/