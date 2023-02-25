// Задайте массив из 12 элементов, заполненный случайными числами изпромежутка от -9 до 9
// Найдите сумму отрицательных и положительных элементов массива.

int[] NewArray(int size){                                          //Метод в котором создаётся массив из заданого диапазона 
    int[] result = new int[size];
    for (int i = 0; i < size; i++) 
    
        result[i] = new Random().Next(-9,10);

    return result;
}

int[] Sum(int[] NewArray)                                          // Метод, в котором мы находим сумму положительных и сумму отрицательных чисел из массива.
{
    int A = 0;
    int B = 0;
    for(int i = 0; i < NewArray.Length; i++)
    {
        if(NewArray[i] < 0 )
        {
            A = A + NewArray[i];
        }
        else
        {
            B = B + NewArray[i];
        }
    }
    int [] NewArray2 = {A,B};
    return NewArray2;
}

Console.Clear();
Console.WriteLine("Введите разрядность массива ");
int size = int.Parse(Console.ReadLine());
int[] array = NewArray(size);
Console.WriteLine($"Генерация нового массива  ... [    {String.Join(", ", array)}     ]");
Console.WriteLine($"Сумма положительных и сумма отрицательных это -> [    {String.Join(", ", Sum(array))}     ]");