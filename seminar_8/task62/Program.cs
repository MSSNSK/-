// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetArray(int size)
{
    int[,] result = new int[size, size];
    int temp = 1;
    int i = 0, j = 0;

    while (temp <= size * size)
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < size - 1)
        {
            j++;
        }
        else if (i < j && i + j >= size - 1)
        {
            i++;
        }
        else if (i >= j && i + j > size - 1)
        {
            j--;
        }
        else
        {
            i--;
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
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]}\t");
            }
            else Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter the dimension of the square array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GetArray(sizeArray);
PrintArray(myArray);
