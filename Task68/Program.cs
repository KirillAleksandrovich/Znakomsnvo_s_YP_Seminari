// Задача 68
// Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int m = EnterValue("Ввод m: ");
int n = EnterValue("Ввод n: ");
Console.WriteLine();
int finalMethod = FunctionСalculations(m, n);
Console.WriteLine($"m = {m}, n = {n} - > A(m,n) = {finalMethod} ");

int EnterValue(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int FunctionСalculations(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FunctionСalculations(m - 1, 1);
    }
    else
    {
        return FunctionСalculations(m - 1, FunctionСalculations(m, n - 1));
    }
}
Console.WriteLine();