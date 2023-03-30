// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета (решать только при помощи операций % и /).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}

int num = ReadInt("Введите трехзначное число");

if (num < 100 || num > 999)
{ 
    Console.WriteLine($" Число {num} не трехзначное");
}
else
{
    Console.WriteLine($"{num} -> {(num / 10 % 10)}");
}

