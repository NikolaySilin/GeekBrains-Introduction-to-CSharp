int [] array = {123, 12322, 233, 6654, 234, 8799, 65};

int n = array.Length;

int find = 233;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}