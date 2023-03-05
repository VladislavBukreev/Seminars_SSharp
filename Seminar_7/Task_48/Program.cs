﻿// **Задача 48:** Задайте 
// двумерный массив размера m на n, каждый элемент
//  в массиве находится по формуле: A[i][j] = i + j. 
//Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5
Console.Clear();
Console.WriteLine("Введите количество строк массива m -> ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбов массива n -> ");
int columns = int.Parse(Console.ReadLine());
int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);


int [,] GetArray(int m, int n , int minValue, int maxValue)
{
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] =  i + j;
        }
    }
    return result;
}
void PrintArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
    Console.WriteLine();
    }
}

