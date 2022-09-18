// Задача 42: 
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

int ConvertToBinary(int number)
{
    int count = 1;
    int result = 0;
    while(number != 0)
    {
        result = (number % 2) * count + result;
        number /= 2;
        count *= 10;
    }
    return result;
}
Console.Write (ConvertToBinary(num));


