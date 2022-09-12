// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X не равно 0 и Y не равно 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка. 
Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвёртая четверть";
    return "Введены не корректные координаты!";   
}

string result = Quarter(x, y);
Console.WriteLine(result);