// **3адача 32:**Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] NewArray(int size)
{                                          
    int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    
        array[i] = new Random().Next(-9,10);

    return array;
}

int[] NewArray2(int[] NewArray)
{
    int[] array = new int[NewArray.Length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * NewArray[i];
    }
return array;
}

Console.Clear();
Console.WriteLine("Введите разрядность массива ");
int size = int.Parse(Console.ReadLine());
int[] array1 = NewArray(size);
Console.WriteLine($"Генерация нового массива  ... [    {String.Join(", ", array1)}     ]");
Console.WriteLine($"Производим инверсию массива  ... [    {String.Join(", ", NewArray2(array1))}     ]");
