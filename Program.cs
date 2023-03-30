// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета (решать только при помощи операций % и /).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}


int num = ReadInt("Введите число");

int result2 = (num / 100 ) ;
int num2 = num;

    if (result2 != 0)
    {
        while(num2 > 1000)
        {
            num2 = num2 /10;
            
        }
        Console.WriteLine($"{num} -> {(num2 % 100) %10}");
    }
    else 
    {
    Console.WriteLine($"{num} Третьего числа нет");
    }