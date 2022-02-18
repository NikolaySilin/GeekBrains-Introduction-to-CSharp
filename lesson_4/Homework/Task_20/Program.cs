// Задать номер четверти, показать диапазоны для возможных координат

int _quarter;
int _digitX;
int _digitY;

string _axisX = "X";
string _axisY = "Y";

int[] _x = new int[11];
int[] _y = new int[11];

void Input(out int quarter)
{
    System.Console.Write("Введите четверть(от 1 до 4): ");
    quarter = Int32.Parse(Console.ReadLine());
}

void FillArray(int[] arrX, int[] arrY, int digitX, int digitY)
{
    if (digitX == 0)
    {
        for (int i = 0; i < arrX.Length; i++)
        {
            arrX[i] = digitX;
            digitX++;
        }
    }
    else if (digitX < 0)
    {
        for (int i = 0; i < arrX.Length; i++)
        {
            arrX[i] = digitX;
            digitX++;
        }
        Array.Reverse(arrX);
    }

    if (digitY == 0)
    {
        for (int y = 0; y < arrY.Length; y++)
        {
            arrY[y] = digitY;
            digitY++;
        }
    }
    else if (digitY < 0)
    {
        for (int y = 0; y < arrY.Length; y++)
        {
            arrY[y] = digitY;
            digitY++;
        }
        Array.Reverse(arrY);
    }

}

void PrintArray(int[] arr, string axis)
{
    System.Console.Write("Диапазон значений по Оси {0}: ", axis);

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

int OutputRange(int quarter, out int digitX, out int digitY)
{
    System.Console.WriteLine("Вы выбрали {0} четверть", quarter);
    digitX = 0;
    digitY = 0;

    if (quarter == 1)
    {
        digitX = 0;
        digitY = 0;
    }
    else if (quarter == 2)
    {
        digitX = 0;
        digitY = -10;
    }
    else if (quarter == 3)
    {
        digitX = -10;
        digitY = -10;
    }
    else if (quarter == 4)
    {
        digitX = -10;
        digitY = 0;
    }
    return quarter;
}

Input(out _quarter);
OutputRange(_quarter, out _digitX, out _digitY);
FillArray(_x, _y, _digitX, _digitY);

PrintArray(_x, _axisX);
System.Console.WriteLine();
PrintArray(_y, _axisY);
