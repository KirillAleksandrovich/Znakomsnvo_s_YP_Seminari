// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int[] numbers = new int [10];
int[] CreateArrayRndInt (int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
    
}
void PrintArray (int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write(array[i] + " ");
        
    }
    Console.Write("]");
    
}
int Change(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = CreateArrayRndInt(10, 0, 1000);
PrintArray(arr);
int result = Change(arr);
Console.WriteLine();
int count = Change(arr);
Console.WriteLine($"Количество четных чисел в массиве: {result} ");
