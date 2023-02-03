/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
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
void RowLessSumElements(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int temp = 0;
    int minRow = 0;
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum = sum + arr[i, j];
            }
            Console.WriteLine(sum);
            if (sum < temp)
            {
                minSum = sum;
                minRow = i;
            }
            temp = sum;
            sum = 0;
        }
        Console.WriteLine($" Минимальная сумма {minSum}, минимальный ряд {minRow + 1}");
    }
}
int[,] array = CreateArray(4, 5);
PrintArray(array);
RowLessSumElements(array);
