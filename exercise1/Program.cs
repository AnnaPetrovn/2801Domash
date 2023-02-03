/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(1, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void BubleInABuble(int[,] arr)
{
    int i, j, u = 0;
    for (i = 0; i < arr.GetLength(0); i++)
    {
        for (j = 0; j < arr.GetLength(1); j++)
        {
            for (u = 0; u < (arr.GetLength(1)); u++)
            {
                if (arr[i, j] > arr[i, u])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, u];
                    arr[i, u] = temp;
                }
            }
        }
    }
}

int[,] col = CreateArray(4, 5);
PrintArray(col);
BubleInABuble(col);
PrintArray(col);
