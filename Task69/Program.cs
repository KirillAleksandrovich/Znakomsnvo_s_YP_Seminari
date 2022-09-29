// Задача 69.
// Напишите программу, 
// которая на вход принимает два числа А и В, 
// и возводит число А в целую степень В с помощью рекурсии.

// A = 3; B = 5 -> 243 (3 в пятой степени)
// A = 2; B = 3 -> 8


int DegreeOfNumber(int c, int d)
{
    if (d == 0) return 1;
    return c *= DegreeOfNumber(c, d - 1);

}
int UserNumber(int number, string message)
{
    Console.Write(message);
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write($"Ошибка ввода. \n{message}");
    }
    return number;
}
bool restart = true;
while (restart)
{

    Console.Clear();
    int a = 0, b = 0;

    a = UserNumber(a, "Введите целое число: ");
    b = UserNumber(b, "В какую степень будем возводить? : ");
    int degree = DegreeOfNumber(a, b);
    Console.WriteLine(degree);

    Console.Write("Повторить? \n'Enter' - Да. Что-то другое - Выход.");
    restart = Console.ReadKey().Key == ConsoleKey.Enter;
    Console.WriteLine();
}
