// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 999);
Console.WriteLine(num);  
int resul1=(num / 10);
Console.WriteLine(resul1 % 10);

