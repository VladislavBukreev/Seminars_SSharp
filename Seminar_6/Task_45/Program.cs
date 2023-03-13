Console.Clear();

Console.WriteLine("Введите кол-во символов в массиве ->");
int size = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите Максимальное число в массиве ... ");
int random = int.Parse(Console.ReadLine());
int[] array = NewArray(size);
Console.WriteLine($"Generation res ...  [    {String.Join(", ", array)}     ]");
CopyArray(array);
Console.WriteLine($"Generation res ...  [    {String.Join(", ", array)}     ]");

int[] NewArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++ )
    {
          res[i] = new Random().Next(0, random);

    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];

    }
    return result;
}
