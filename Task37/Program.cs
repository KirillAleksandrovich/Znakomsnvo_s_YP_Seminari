// Задача 37.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент,
// второй и предпоследний и т.д.
// Результаты запишите в новом массиве.

// [1 2 3 4 5] ->583
// [6 7 3 6] -> 36 21

Console.Clear();

int[] CreadArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] ArrayMult(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0) size += 1;
    int[] arraymult = new int[size];
    if(arraymult.Length % 2 == 0)
    {
    for (int i = 0; i < array.Length / 2; i++)
    
        {
        arraymult[i] = array[i] * array[array.Length - 1 - i];
        }
    }

    else 
        for (int i = 0; i < array.Length / 2; i++)
        {
            arraymult[i] = array[i] * array[array.Length - 1 - i];
            arraymult[arraymult.Length - 1] = array[array.Length / 2];
        } 
    return arraymult;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] arr = CreadArrayRndInt(4, 1, 10);
int[] result = ArrayMult(arr);
PrintArray(arr);
Console.Write("->");
PrintArray(result);
