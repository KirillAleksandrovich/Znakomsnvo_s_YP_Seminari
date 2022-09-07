// 16. Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно 
// число корнем другого.
// 5, 25 -> да
// -4, 16-> да
// 25, 5 -> да
// 8, 9 -> нет
Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool square(int a1, int b1)
{
    return (a1 * a1 == b1 || b1 * b1 == a1);
}
bool result = square(num1, num2);
if (result) Console.WriteLine($"Правда");
else Console.WriteLine($"Ложь");