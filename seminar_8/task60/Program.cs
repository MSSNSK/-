// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void GetArray(int[,,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        result[i] = new Random().Next(10, 100);
        int number = result[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (result[i] == result[j])
                {
                    result[i] = new Random().Next(10, 100);
                    j = 0;
                    number = result[i];
                }
                number = result[i];
            }
        }
    }

    int count = 0;

    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = result[count];
                count++;
            }
        }
    }
}

void PrintElementsAndIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
        }
    }
}

Console.Write("Enter the number of rows in the array (x): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns in the array (y): ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of layers in the array (z): ");
int layer = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = new int[row, column, layer];

int maxTwoDigitNumber = 99;

if (row * column * layer > maxTwoDigitNumber)
{
    Console.WriteLine("The range of the array is wider than non-repeating two-digit elements!");
    return;
}

GetArray(myArray);
PrintElementsAndIndex(myArray);
