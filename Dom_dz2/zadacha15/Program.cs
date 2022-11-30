//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 6) Console.WriteLine("Выбраный день рабочий");
else if (day > 5 && day < 8) Console.WriteLine("Выбранный день выходной");
else Console.WriteLine("Номер дня введен неверно");
