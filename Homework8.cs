// int[,] array = new int[4, 3];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//     }
// }

// void Printarray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// Printarray(array);
// System.Console.WriteLine();

// Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] ReverseSort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int[] rows = new int[array.GetLength(1)];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             rows[j] = array[i, j];
//         }
//         array.Sort(rows);
//         array.Reverse(rows);
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rows[j];
//         }
//     }

//     return array;
// }

// Printarray(ReverseSort(array));

// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] Create2DArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Input rows size: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input columns size: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DArray(rows, columns);

// if (rows == columns) System.Console.WriteLine("Invalid size");
// else
// {
// PrintArray(array);
// System.Console.WriteLine();

//     int MinSum(int[,] array)
//     {
//         int minSumRow = 0;
//         int minSum = int.MaxValue;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum += array[i, j];
//             }

//             System.Console.WriteLine($"Сумма строки {i}: {sum}");

//             if (sum < minSum)
//             {
//                 minSum = sum;
//                 minSumRow = i;
//             }
//         }
//         return minSumRow;
//     }

//     System.Console.WriteLine($"Row with the minimum sum of elements -> {MinSum(array)}");
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] Create2DArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] Create2DMatrix(int rows, int columns)
// {
//     int[,] matrix2 = new int[rows, columns];
//     for (int i = 0; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             matrix2[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return matrix2;
// }

// System.Console.WriteLine("Input rows size: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input columns size: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix1 = Create2DArray(rows, columns);

// System.Console.WriteLine("Input rows size for second matrix: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input columns size for second matrix: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// int[,] matrix2 = Create2DMatrix(rows2, columns2);

// PrintArray(matrix1);
// System.Console.WriteLine();
// PrintArray(matrix2);
// System.Console.WriteLine();

// int[,] ResultMatrix(int[,] array, int[,] matrix2)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     int rows2 = matrix2.GetLength(0);
//     int columns2 = matrix2.GetLength(1);
//     int[,] resultMatrix = new int[rows, columns2];

//     if (columns != rows2) System.Console.WriteLine("Invalid input");
//     else
//     {
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns2; j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < columns; k++)
//                 {
//                     sum += array[i, k] * matrix2[k, j];
//                 }
//                 resultMatrix[i, j] = sum;
//             }
//         }
//     }

//     return resultMatrix;
// }

// PrintArray(ResultMatrix(matrix1, matrix2));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] Create3DArray(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     Random random = new Random();
//     for (int i = 0; i < size1; i++)
//     {
//         for (int j = 0; j < size2; j++)
//         {
//             for (int k = 0; k < size3; k++)
//             {
//                 int randomNumber = random.Next(10, 100);

//                 while (NumberExist(array, randomNumber))
//                 {
//                     randomNumber = random.Next(10, 100);
//                 }

//                 array[i, j, k] = randomNumber;
//             }
//         }
//     }
//     return array;
// }

// bool NumberExist(int[,,] array, int number)
// {
//     foreach (int element in array)
//     {
//         if (element == number) return true;
//     }
//     return false;
// }

// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 System.Console.Write(array[i, j, k] + " ");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Input rows size");
// int size1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input columns size");
// int size2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input deep size");
// int size3 = Convert.ToInt32(Console.ReadLine());

// int[,,] array = Create3DArray(size1, size2, size3);
// Print3DArray(array);

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int size = 4;
int[,] spiralArray = new int[size, size];

int value = 1;
int rowStart = 0, rowEnd = size - 1;
int colStart = 0, colEnd = size - 1;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    // Заполнение верхней строки
    for (int i = colStart; i <= colEnd; i++)
    {
        spiralArray[rowStart, i] = value++;
    }
    rowStart++;

    // Заполнение правого столбца
    for (int i = rowStart; i <= rowEnd; i++)
    {
        spiralArray[i, colEnd] = value++;
    }
    colEnd--;

    // Заполнение нижней строки
    if (rowStart <= rowEnd)
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            spiralArray[rowEnd, i] = value++;
        }
        rowEnd--;
    }

    // Заполнение левого столбца
    if (colStart <= colEnd)
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiralArray[i, colStart] = value++;
        }
        colStart++;
    }
}

// Вывод массива в консоль
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(spiralArray[i, j] + "\t");
    }
    Console.WriteLine();
}