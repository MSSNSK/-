// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyingArrays(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] result = new int[arrayFirst.GetLength(0), arrayFirst.GetLength(1)];

    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                result[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
    return result;
}

Console.Write("Enter the number of rows in the arrays: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the arrays: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum element of the arrays: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum element of the arrays: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = GetArray(row, column, min, max);
Console.WriteLine("The first array:");
PrintArray(firstArray);

Console.WriteLine();
int[,] secondArray = GetArray(row, column, min, max);
Console.WriteLine("The second array:");
PrintArray(secondArray);

Console.WriteLine();
int[,] finalArray = MultiplyingArrays(firstArray, secondArray);
Console.WriteLine("The resulting array:");
PrintArray(finalArray);
