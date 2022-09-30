// Задача 66. 
// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"\nM = {m}; N = {n} -> ");
Console.WriteLine(NaturalNumbers(m, n));

int NaturalNumbers(int m, int n)
{
    int numberM = m;
    int numberN = n;
    if (m > n)
    {
        numberM = n;
        numberN = m;
    }
    return (numberN + numberM) * (numberN - numberM + 1) / 2;
}
