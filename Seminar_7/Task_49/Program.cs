﻿// **3адача 49:** Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 2 3 4
// Новый массив будет выглядеть вот так:
//1 4 7 2
//5 **81** 2 **9**
//8 4 2 4
//1 **4** 3 **16**

Console.Clear();
Console.Write("Введите кол-во строк в массиве -> ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве -> ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Какое максимальное число от 0 будет в массиве -> ");
int rand = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, rand);
PrintArray(array);
Console.WriteLine();
PrintArray(Method(array));

int[,] GetArray(int m, int n, int minValue, int maxValue)  // как всегда создаём рандомный массив
{
    int[,] result = new int[m,n];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            result[i,j] = new Random().Next(rand);
        }
    }
    return result; 
}


int[,] Method(int[,] array)      // Метод возведения в квадрат числа с индексоми которых чётные
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             if (i % 2 == 1 && j % 2 == 1)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}

void PrintArray(int[,] inArray)  // печатаем массив
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
