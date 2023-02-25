// **3адача 32:**Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
Console.Clear();
int[] startArray = GetArray(6, -10, 10);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine(String.Join(" ", InversArray(startArray)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    
    for (int i = 0; i < size; i++)
    
    {	
        res[i] = new Random().Next(minValue, maxValue + 1); 
    } 
    return res;
}
int[] InversArray(int[] array)// [1, -2, 3, -4, 5] ->[-1,2,-3,4,-5] 
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {   
        array[i] *= -1; 
    }
    /*int j = 0;
    foreach (int i in array) {
    result[j] = i * -1;
    j++;
    }*/
    return array;
}
