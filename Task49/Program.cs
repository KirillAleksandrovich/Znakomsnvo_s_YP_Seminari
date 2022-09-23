﻿// // Задача 49.
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив                 Нвый массив будет выглядеть 
// выглядел вот так:                           вот так:
// 1 4 7 2                                     1 4 49 2
// 5 9 2 3                                     5 81 2 9 
// 8 4 2 4                                     64 4 4 4

Console.Clear();

int[,] CreadMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

void SquareEvenElems(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
}
int[,] array2D = CreadMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
SquareEvenElems(array2D);
Console.WriteLine();
PrintMatrix(array2D);