// // Задача 54: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2


// int[,] arr = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4}
//         };

// for (int i = 0; i < arr.GetLength(0); i++)
// {

//     for (int j = 0; j < arr.GetLength(1) - 1; j++)
//     {
//         int maxIndex = j;
//         for (int k = j + 1; k < arr.GetLength(1); k++)
//         {
//             if (arr[i, k] > arr[i, maxIndex])
//             {
//                 maxIndex = k;
//             }
//         }
//         int temp = arr[i, j];
//         arr[i, j] = arr[i, maxIndex];
//         arr[i, maxIndex] = temp;
//     }
// }

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// // которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке 
// // и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// int[,] array = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4},
//             {5, 2, 6, 7}
//         };

// int minSum = int.MaxValue;
// int minIndex = -1;
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         sum += arr[i, j];
//     }

//     if (sum < minSum)
//     {
//         minSum = sum;
//         minIndex = i;
//     }
// }

// Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minIndex + 1));


// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18


// int[,] matrix1 = {
//             {2, 4},
//             {3, 2}
//         };
// int[,] matrix2 = {
//             {3, 4},
//             {3, 3}
//         };

// if (matrix1.GetLength(1) != matrix2.GetLength(0))
// {
//     Console.WriteLine("Матрицы нельзя перемножить");
//     return;
// }


// int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int k = 0; k < matrix1.GetLength(1); k++)
//         {
//             sum += matrix1[i, k] * matrix2[k, j];
//         }
//         resultMatrix[i, j] = sum;
//     }
// }
// Console.WriteLine("Произведение двух матриц:");
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//         Console.Write(resultMatrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }


