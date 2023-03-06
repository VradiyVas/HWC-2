
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = Convert.ToString(number);
if (numberString.Length > 2)
{
    Console.WriteLine("Третья цифра  " + numberString[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


