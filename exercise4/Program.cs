/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
int[,,] CreateMassiveTwoDigitNumber()
{
    int number = 9;
    int[,,] array = new int[9, 3, 3];
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                number++;
                array[a, b, c]  = number;
            }
        }
    }
    return array;
}
void PrintTridimensionalArray(int[,,] arr)
{
    for (int a = 0; a < arr.GetLength(0); a++)
    {
        for (int b = 0; b < arr.GetLength(1); b++)
        {
            for (int c = 0; c < arr.GetLength(2); c++)
            {
                Console.Write(arr[a, b, c] + " " + " индекс элемента " + a + "," + b  + "," + c + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintTridimensionalArray(CreateMassiveTwoDigitNumber());
