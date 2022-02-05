//Определить, присутствует ли в заданном массиве, некоторое число

int[] array = {-1, 2, 5, 7, -9, 11, 32, 18};

System.Console.Write("Введите цифру: ");

string digit = Console.ReadLine();

int a = Int32.Parse(digit);

bool findDigit (int []arr, int number)
{
    bool ask = false;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == number)
        {
            ask = true;
        }
    }
    System.Console.Write(ask);
    return ask;
}



findDigit(array, a);