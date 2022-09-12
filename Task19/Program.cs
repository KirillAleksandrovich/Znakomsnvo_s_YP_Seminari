// Задача 19: Напишите программу, 
//которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

void Num(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"{number} -> Да.");
  }
  else Console.WriteLine($"{number} -> Нет.");
}

if (number!.Length == 5)
{
  Num(number);  
}
else Console.WriteLine($"Введите пятизначное число");