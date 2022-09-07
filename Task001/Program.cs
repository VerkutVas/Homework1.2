// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(0, 199);
Console.WriteLine(num);
if (num > 100)
{
    Console.WriteLine(num / 100 / 10 + num % 10);
}
else
{
    Console.WriteLine("Третий цифры нет");
}