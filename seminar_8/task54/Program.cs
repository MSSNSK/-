// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int rowArray, int columnArray, int minValue, int maxValue)
{
    int[,] result = new int[rowArray, columnArray];

    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SortToLow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Enter the number of rows in the array: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the array: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GetArray(row, column, min, max);
PrintArray(myArray);

Console.WriteLine();
Console.WriteLine("Array with stained in descending elements of each row:");
SortToLow(myArray);
PrintArray(myArray);

// ВТОРОЙ ВАРИАНТ.
// Задание на упорядочивание по возрастанию, как было озвучено на семинаре:

// int[,] GetArray(int rowArray, int columnArray, int minValue, int maxValue)
// {
//     int[,] result = new int[rowArray, columnArray];

//     for (int i = 0; i < rowArray; i++)
//     {
//         for (int j = 0; j < columnArray; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortToUp(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] > array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.Write("Enter the number of rows in the array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number of columns in the array: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the minimum element of the array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the maximum element of the array: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = GetArray(row, column, min, max);
// PrintArray(myArray);

// Console.WriteLine();
// Console.WriteLine("Array with stained in increasing elements of each row:");
// SortToUp(myArray);
// PrintArray(myArray);
