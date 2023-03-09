//Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, 
//если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
Console.WriteLine("Введите количество строк в массиве -> ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве -> ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте максимально возможное число -> ");
int rand = int.Parse(Console.ReadLine());

int [,] array = GetArray(rows, columns , 0, rand);
PrintArray(array);
ChangeArray2(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int n, int m, int minValue, int rand)
{
    int[,] result = new int[n,m];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            result[i,j] = new Random().Next(minValue , rand);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray2(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("В данной матрице нельзя заменить элементы!");
        return;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int k = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = k;
        }
    }
}