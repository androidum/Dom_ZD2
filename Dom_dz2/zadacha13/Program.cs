//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

 Console.WriteLine("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());
 if (num > 99)
 {
     while (num > 999)
     {
         num = num / 10;
     }
     Console.WriteLine($"Третья цифра {num % 10}");
 }
 else Console.WriteLine("Третьей цифры нет");