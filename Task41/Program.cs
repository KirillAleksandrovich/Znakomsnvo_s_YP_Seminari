//Задача 41.
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Укажите, сколько цифр нужно внести: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] array = new int[count];
int i = 0;
while (i < count)
{
    Console.Write("Введите цифру: ");
    int digit = Convert.ToInt32(Console.ReadLine());
    array[i] = digit;
    i += 1;
}

int countDigit = 0;
int j = 0;
while (j < array.Length)
{
    if (array[j] > 0) countDigit += 1;
    j += 1;
}
Console.WriteLine();
Console.WriteLine($"Всего-> {countDigit} числа больше 0");