/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (99 < digit && digit < 999)
{
    int thirdDigit = digit % 10;
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else if (999 < digit && digit < 9999)
{
    int thirdDigit = (digit / 10) % 10;
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}    
else if (9999 < digit && digit < 99999)
{
    int thirdDigit = (digit / 100) % 10;
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет: ");
}



