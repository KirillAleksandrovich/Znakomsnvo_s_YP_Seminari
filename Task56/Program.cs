// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] array = new int[4, 4];
void CreateMatrixRndInt(int[,] array)
{
    int minRows = 0;
    int minSummRows = 0;
    int summRows = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRows += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) summRows += array[i, j];
        if (summRows < minRows)
        {
            minRows = summRows;
            minSummRows = i;
        }
        summRows = 0;
    }
    Console.Write($"C наименьшей суммой элементов: {minSummRows +1} строка!");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j]= new Random().Next(1, 10);
        }
    }
}
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
CreateMatrixRndInt(array);