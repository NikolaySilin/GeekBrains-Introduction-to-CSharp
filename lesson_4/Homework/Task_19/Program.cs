// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int _x, _y;

void Input(out int x,out int y)
{
    System.Console.Write("Ввидите координату x: ");
    x = Int32.Parse(Console.ReadLine());

    System.Console.Write("Введите координату y: ");
    y = Int32.Parse(Console.ReadLine());

    System.Console.WriteLine("x = {0}, y = {1}", x, y);
}

void QuarterCheck(int x, int y)
{
    if(x > 0 && y > 0)
    {
        System.Console.WriteLine("Точка с координатами X = {0}, Y = {1} находится в I четверти", x, y);
    }
    else if(x > 0 && y < 0)
    {
        System.Console.WriteLine("Точка с координатами X = {0}, Y = {1} находится во II четверти", x, y);
    }
    else if(x < 0 && y < 0)
    {
        System.Console.WriteLine("Точка с координатами X = {0}, Y = {1} находится в III четверти", x, y);
    }
    else if(x < 0 && y > 0)
    {
        System.Console.WriteLine("Точка с координатами X = {0}, Y = {1} находится в IV четверти", x, y);
    }
    else if(x == 0 && y == 0)
    {
        System.Console.WriteLine("Нарушено условие задачи");
    }
}

Input(out _x,out _y);
QuarterCheck(_x, _y);

