/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int[,] MultiplicationOfTwoMatrices(int[,] array, int[,] coll)
{
    int row = 0;
    int column = 0;
    int[,] arr = new int[2, 2];
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int j = 0; j < array.GetLength(1) && j < coll.GetLength(0); j++)
        {
            row = row + array[a, j] * coll[j, 0];
            column = column + array[a, j] * coll[j, 1];
        }
        arr[a, 0] = row;
        arr[a, 1] = column;
        row = 0;
        column = 0;
    }
    return arr;
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
// Использую массив из двух строк и двух столбиков, так как для решения данной задачи количество столбцов 
// в одном массиве должно соответствовать количеству строчек в другом массиве.
//Задавать массив трехмерным или четырехмерным мне кажется слишком сложной задачей
int[,] a = { { 2, 4 }, { 3, 2 } };
int[,] b = { { 3, 4 }, { 3, 3 } };
PrintArray(MultiplicationOfTwoMatrices(a, b));
