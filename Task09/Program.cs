// Напишите программу, 
//которая выводит случайное число из отрезка[10, 99] 
//и показывает наибольшую цифру чмсла.
// 78->8
// 12->2
// 85->8
//88-> цифры одинаковые
Console.Clear();
//int num = new Random().Next(10, 100);
// int firstDigit = num / 10; //7
// int secondDigit = num % 10; //8

//if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа{num} -> {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа {num} -> {secondDigit}");
// if(firstDigit == secondDigit) Console.WriteLine($"Цифры равны");
// else{
// int max = firstDigit > secondDigit ? firstDigit : secondDigit;//Тернарный оператор. ?-тогда, :-иначе.
// Console.WriteLine($"Наибольшая цифра числа {num} -> {max}");
// }
int num = new Random().Next(10, 100);

int MaxDigit(int number)
{
  int firstDigit = number / 10; //7
  int secondDigit = number % 10; //8 
  if(firstDigit == secondDigit) return 0;
  return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(num);
string result = maxDigit > 0 ? maxDigit.ToString() :"Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {num} -> {result}");

