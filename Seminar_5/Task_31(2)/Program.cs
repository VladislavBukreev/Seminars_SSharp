// Задайте массив из 12 элементов, заполненный случайными числами изпромежутка от -9 до 9
// Найдите сумму отрицательных и положительных элементов массива.

int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
int[] SumPosNeg(int[] array) 
{
    int[] result = new int[2];
    foreach (int el in array)//[l, 2, 3, 4, -5, 1, -3] el = -5 
    {
        result[0] += el > 0 ? el : 0;//ps += -5 > 0? 2 : 0;
        result[1] += el < 0 ? el : 0;
    }
return result;
}

Console.WriteLine($"Positive sum = {SumPosNeg(array)[0]}, negative sum = {SumPosNeg(array)[1]}");
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}