//Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист"
// например: 1 программист, 2 программиста, 5 программистов.

 Console.WriteLine("Введите количество программистов");
 int count = Convert.ToInt32(Console.ReadLine());
 if (count == 1 || count % 10 == 1) Console.WriteLine($"{count} программист");
 else if (count > 1 && count < 5 || count % 10 > 1 && count % 10 < 5) Console.WriteLine($"{count} программиста");
 else Console.WriteLine($"{count} программистов");
