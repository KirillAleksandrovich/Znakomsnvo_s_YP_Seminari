//Задача 43.
// Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine();

Console.Write("Введите значение b1: ");
double digit1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
double digit2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double digit3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double digit4 = Convert.ToInt32(Console.ReadLine());

void SelectiveSearch(double dig1, double dig2, double dig3, double dig4)
{
    double y = ((dig2 * (dig3 - dig1) / (dig2 - dig4)) + dig1);
    double x = ((dig3 - dig1) / (dig2 - dig4));
    Console.WriteLine($"({Math.Round(x, 1)}; {Math.Round(y, 1)})");
}
Console.WriteLine();
SelectiveSearch(digit1, digit2, digit3, digit4);
