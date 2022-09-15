// Задача 29: 
// Напишите программу,
// которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] arr = new int[8];

 void ArrayRandomFiller(int[] arr)
 {
     Random randArr = new Random();
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = randArr.Next(0, 100);
     }
 }

void ArrayRandomPrint(int[] arr)
 {
     for (int i = 0; i < arr.Length; i++)
     {
         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
         else Console.Write($"{arr[i]} ->");
     }
     Console.Write(" [");
     for (int i = 0; i < arr.Length; i++)
     {
         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
         else Console.Write($"{arr[i]}");
     }
     Console.Write("]");
 }

ArrayRandomFiller(arr);
ArrayRandomPrint(arr);

// Заполнение массива:

// void ArrayRandomFiller(int[] arr)
// {
//     Random randArr = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = randArr.Next(0, 100);
//     }
// }

// Печать:

// void ArrayRandomPrint(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]} ->");
//     }
//     Console.Write(" [");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }


