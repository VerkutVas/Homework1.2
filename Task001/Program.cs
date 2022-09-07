// Задача 2

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