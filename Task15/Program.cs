/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Да, ВЫХОДНОЙ!!!: ");
}
else if (dayNumber == 1 || dayNumber < 6)
{
    Console.WriteLine("К сожалению, нет ");
}    
else
{
    Console.WriteLine("Цифра не соответствует дню недели: ");
}
    


