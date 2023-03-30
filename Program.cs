// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}


int num = ReadInt("Введите число");
string[] Days = {"день. Сегодня можно лечь спать поздно", "дня. Ты почти у цели", "дня. Это уже середина", "дня. Все не так плохо", "дней. Крепись Бро!"};
int index = 5 - num;

if(num < 8)
{
    if(num >5)
    {
        Console.WriteLine($"Ура! Выходной");
    }
    else
    {
         Console.WriteLine($"До выходного осталось: {5 - num + 1} {Days[index]} ");
    }
}
else
{
    Console.WriteLine($"В неделе 7, а не {num} дней");
}